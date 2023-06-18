using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI
{
    public partial class OrderViewDrinks : Form
    {
        private List<OrderItem> items = new List<OrderItem>();
        private Order order;
        private List<Product> products;
        private string employeeName;

        public OrderViewDrinks(List<OrderItem> items, Order order, List<Product> products, string employeeName)
        {
            InitializeComponent();
            this.order = order;
            this.items = items;
            this.products = products;
            this.employeeName = employeeName;
            DisplayOrderItems();
        }

        // Start Buttons
        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderView = new OrderViewLunch(items, order, products, employeeName);
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            OrderViewDinner orderView = new OrderViewDinner(items, order, products, employeeName);
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            OrderViewDrinks orderView = new OrderViewDrinks(items, order, products, employeeName);
            orderView.Show();
            this.Hide();
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

                OrderViewAddComment commentView = new OrderViewAddComment("Lunch", item, items, order, products, employeeName);
                commentView.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
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

        private void orderViewFinishBtn_Click(object sender, EventArgs e)
        {
            OrderViewFinishOrder orderView = new OrderViewFinishOrder(items, order, products, employeeName);
            orderView.Show();
            this.Hide();
        }
        // End Buttons


        private void OrderViewDrinks_Load(object sender, EventArgs e)
        {
            DisplayDrinkProducts();
            orderViewTableLbl.Text = $"TABLE: {order.TableId}";
            nameLbl.Text = employeeName;
        }

        private void DisplayDrinkProducts()
        {
            List<Product> products = LoadDrinksProducts();
            List<Product> softDrinksProducts = SortDrinkProductsOnType(new List<Product>(products), ProductType.SoftDrinks);
            List<Product> beerProducts = SortDrinkProductsOnType(new List<Product>(products), ProductType.Beer);
            List<Product> wineProducts = SortDrinkProductsOnType(new List<Product>(products), ProductType.Wine);
            List<Product> spiritProducts = SortDrinkProductsOnType(new List<Product>(products), ProductType.Spirit);
            List<Product> hotDrinkProducts = SortDrinkProductsOnType(new List<Product>(products), ProductType.CoffeeAndTea);

            OrderViewDrinkUC orderViewFLP;
            foreach (Product product in softDrinksProducts)
            {
                orderViewFLP = new OrderViewDrinkUC(product, this);
                this.OrderViewSoftDrinksFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in beerProducts)
            {
                orderViewFLP = new OrderViewDrinkUC(product, this);
                this.OrderViewBeersFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in wineProducts)
            {
                orderViewFLP = new OrderViewDrinkUC(product, this);
                this.OrderViewWinesFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in spiritProducts)
            {
                orderViewFLP = new OrderViewDrinkUC(product, this);
                this.OrderViewSpiritsFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in hotDrinkProducts)
            {
                orderViewFLP = new OrderViewDrinkUC(product, this);
                this.OrderViewHotDrinksFLP.Controls.Add(orderViewFLP);
            }
        }

        private List<Product> LoadDrinksProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllDrinksProducts();
            return products;
        }

        private List<Product> SortDrinkProductsOnType(List<Product> products, ProductType productType)
        {
            List<Product> productsCopy = new List<Product>(products); // Create a copy of the products list so it doesnt get modified during a foreach loop

            foreach (Product product in productsCopy)
            {
                if (product.Type != productType)
                    products.Remove(product);
            }

            return products;
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

        public void AddProductToOrderItem(Product product)
        {
            try
            {
                // I am using a "lambda expression" here, basically it uses Product _product as input and then checks if the productId exists in the list
                int index = products.FindIndex(_product => _product.ProductId == product.ProductId);
                if (products[index].Stock == 0)
                    throw new Exception("product is out of stock");
                products[index].Stock -= 1; // temporarily decreases stock
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
    }
}
