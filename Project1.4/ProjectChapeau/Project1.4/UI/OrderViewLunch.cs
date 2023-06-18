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

        private List<OrderItem> items = new List<OrderItem>();
        private Order order;
        public OrderViewLunch() // TODO receive table id from tables // Employee name
        {
            InitializeComponent();
            OrderService service = new OrderService();
            order = new Order(service.GetNextAvailableOrderId(), 0, DateTime.Now, DateTime.Now);
        }

        public OrderViewLunch(List<OrderItem> items, Order order) // Employee name
        {
            InitializeComponent();
            this.order = order;
            this.items = items;
            DisplayOrderItems();

        }

        // Start Display methods
        private void DisplayLunchProducts()
        {
            List<Product> products = LoadLunchProducts();
            List<Product> entreeProducts = SortLunchProductsOnType(new List<Product>(products), ProductType.Entree);
            List<Product> mainCourseProducts = SortLunchProductsOnType(new List<Product>(products), ProductType.MainCourse);
            List<Product> dessertProducts = SortLunchProductsOnType(new List<Product>(products), ProductType.Dessert);

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
            List<Product> products = service.GetAllProducts();
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

        private List<Product> SortLunchProductsOnType(List<Product> products, ProductType productType)
        {
            List<Product> productsCopy = new List<Product>(products); // Create a copy of the products list so it doesnt get modified during a foreach loop

            foreach (Product product in productsCopy)
            {
                if (product.Type != productType)
                    products.Remove(product);
            }

            return products;
        }

        // Start Load methods

        private List<Product> LoadLunchProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllLunchProducts();
            return products;
        }

        // End Loadmethods
        public void AddProductToOrderItem(Product product)
        {
            try
            {
                if (product.Stock == 0) 
                    throw new Exception("product is out of stock");
                product.Stock -= 1; // temporarily decreases stock
                OrderItem orderItem = new OrderItem(0, order.OrderId, product.ProductId, 1, "geen", OrderStatusEnum.Inpreparation);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void RemoveProductFromOrderItem(string name)
        {
            OrderItem itemToRemove = GetOrderItemWithName(name);
            if (itemToRemove != null)
            {
                int index = items.IndexOf(itemToRemove); // just to get the index rq
                if (itemToRemove.Amount > 1)
                {
                    items[index].Amount -= 1;
                }
                else
                {
                    items.Remove(itemToRemove);
                }
            }
            DisplayOrderItems();
        }

        private OrderItem GetOrderItemWithName(string name)
        {
            int productId = 0;
            ProductService service = new ProductService();
            foreach (Product product in service.GetAllProducts())
            {
                if (product.Name == name)
                {
                    productId = product.ProductId;
                    break;
                }
            }

            OrderItem itemToGet = null;
            if (productId != 0)
            {
                foreach (OrderItem item in items)
                {
                    if (item.ProductId == productId)
                    {
                        itemToGet = item;
                        break;
                    }
                }
            }
            return itemToGet;
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            OrderViewDinner orderView = new OrderViewDinner(items, order);
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            OrderViewDrinks orderView = new OrderViewDrinks(items, order);
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderView = new OrderViewLunch(items, order);
            orderView.Show();
            this.Hide();
        }

        private void OrderViewLunch_Load(object sender, EventArgs e)
        {
            DisplayLunchProducts();
        }

        private void orderViewRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderItemLV.SelectedItems.Count == 0)
                    throw new Exception("Please select aleast 1 item, Do this by clicking the amount");
                ListViewItem selectedItem = orderItemLV.SelectedItems[0];
                string itemName = selectedItem.SubItems[1].Text;
                RemoveProductFromOrderItem(itemName);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void orderViewCommentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderItemLV.SelectedItems.Count == 0)
                    throw new Exception("Please select aleast 1 item, Do this by clicking the amount");
                ListViewItem selectedItem = orderItemLV.SelectedItems[0];
                string itemName = selectedItem.SubItems[1].Text;
                OrderItem item = GetOrderItemWithName(itemName);

                OrderViewAddComment commentView = new OrderViewAddComment("Lunch", item, items, order);
                commentView.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void orderViewFinishBtn_Click(object sender, EventArgs e)
        {
            OrderViewFinishOrder orderView = new OrderViewFinishOrder(items, order);
            orderView.Show();
            this.Hide();
        }
    }
}
