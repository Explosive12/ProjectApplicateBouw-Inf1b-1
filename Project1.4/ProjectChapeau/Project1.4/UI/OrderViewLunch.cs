using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1._4.Service;
using Project1._4.Model;
using Project1._4.UI;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Graph.Models;

namespace Project1._4
{
    public partial class OrderViewLunch : Form
    {

        public List<OrderItem> items = new List<OrderItem>();
        public Order order;
        public OrderViewLunch()
        {
            InitializeComponent();
            OrderService service = new OrderService();
            order = new Order(service.GetNextAvailableOrderId(), 0, DateTime.Now, DateTime.Now);
        }


        // Start Display methods
        private void DisplayLunchProducts()
        {
            List<Product> products = LoadLunchProducts();
            List<Product> entreeProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.Entree);
            List<Product> mainCourseProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.MainCourse);
            List<Product> dessertProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.Dessert);

            OrderViewLunchUC orderViewFLP;
            foreach (Product product in entreeProducts)
            {
                orderViewFLP = new OrderViewLunchUC(product, this);
                this.OrderViewStarterFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in mainCourseProducts)
            {
                orderViewFLP = new OrderViewLunchUC(product, this);
                this.OrderViewMainFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in dessertProducts)
            {
                orderViewFLP = new OrderViewLunchUC(product, this);
                this.OrderViewDessertsFLP.Controls.Add(orderViewFLP);
            }
        }

        public void DisplayOrderItems()
        {
            orderItemLV.Items.Clear();
            ProductService service = new ProductService();
            List<Product> products = LoadLunchProducts();
            foreach (OrderItem item in items)
            {
                List<Product> nameProducts = service.GetProductById(item.ProductId);
                string itemName = nameProducts[0].Name;
                ListViewItem li = new ListViewItem(item.Amount.ToString());
                li.SubItems.Add(itemName);
                orderItemLV.Items.Add(li);
            }
        }
        // End Display methods

        private List<Product> SortLunchProductsOnType(List<Product> products, ProductTypeEnum productType)
        {
            List<Product> productsCopy = new List<Product>(products); // Create a copy of the products list so it doesnt get modified during a foreach loop

            foreach (Product product in productsCopy)
            {
                if (product.ProductType != productType)
                    products.Remove(product);
            }

            return products;
        }

        // Start Load methods
        private List<Menu> LoadMenu()
        {
            MenuService service = new MenuService();
            List<Menu> menuList = service.GetAllMenuItems();
            return menuList;
        }

        private List<Product> LoadLunchProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllLunchProducts();
            return products;
        }

        private List<Order> LoadOrders()
        {
            OrderService service = new OrderService();
            List<Order> orders = service.GetAllOrders();
            return orders;
        }

        private List<OrderItem> LoadOrderItems()
        {
            OrderItemService service = new OrderItemService();
            List<OrderItem> orderItems = service.GetAllOrderItems();
            return orderItems;
        }
        // End Loadmethods
        public void AddProductToOrderItem(Product product)
        {
            OrderItem orderItem = new OrderItem(0, order.OrderId, product.ProductId, 1, "geen", OrderStatusEnum.Bezig);
            List<OrderItem> itemsToAdd = new List<OrderItem>();

            bool found = false;
            foreach (OrderItem item in items)
            {
                if (item.ProductId == orderItem.ProductId)
                {
                    item.Amount += 1;
                    found = true;
                }
            }

            if (!found)
            {
                itemsToAdd.Add(orderItem);
            }
            items.AddRange(itemsToAdd);
        }

        private void RemoveProductFromOrderItem(string name)
        {
            int productIdToRemove = 0;
            ProductService service = new ProductService();
            foreach (Product product in service.GetAllProducts())
            {
                if (product.Name == name)
                {
                    productIdToRemove = product.ProductId;
                    break;
                }
            }

            if (productIdToRemove != 0)
            {
                OrderItem itemToRemove = null;

                foreach (OrderItem item in items)
                {
                    if (item.ProductId == productIdToRemove)
                    {
                        itemToRemove = item;
                        break;
                    }
                }

                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                }
            }
            DisplayOrderItems();
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            //OrderViewDinner orderView = new OrderViewDinner();
            //orderView.Show();
            //this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            //OrderViewDrinks orderView = new OrderViewDrinks();
            //orderView.Show();
            //this.Hide();
        }

        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderView = new OrderViewLunch();
            orderView.Show();
            this.Hide();
        }

        private void OrderViewLunch_Load(object sender, EventArgs e)
        {
            DisplayLunchProducts();
        }

        private void orderViewRemoveBtn_Click(object sender, EventArgs e)
        {
            if (orderItemLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = orderItemLV.SelectedItems[0];
                string itemName = selectedItem.SubItems[1].Text;
                RemoveProductFromOrderItem(itemName);
            }
        }

        private void orderViewCommentBtn_Click(object sender, EventArgs e)
        {

        }

        private void orderViewFinishBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
