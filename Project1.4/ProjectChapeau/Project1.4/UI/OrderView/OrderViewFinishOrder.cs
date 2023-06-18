using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI
{
    public partial class OrderViewFinishOrder : Form
    {
        private List<OrderItem> items = new List<OrderItem>();
        private Order order;
        private List<Product> products;
        private string employeeName;


        private decimal price;
        private decimal vatPrice;

        const decimal AlcVAT = 0.21M;
        const decimal VAT = 0.09M;

        public OrderViewFinishOrder(List<OrderItem> items, Order order, List<Product> products, string employeeName)
        {
            InitializeComponent();
            this.items = items;
            this.order = order;
            this.products = products;
            this.employeeName = employeeName;
            DisplayOrderItems();
            DisplayPrice();
        }

        private void DisplayOrderItems()
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
                li.SubItems.Add(nameProducts[0].Price.ToString());
                orderItemLV.Items.Add(li);

                price += (item.Amount * nameProducts[0].Price);
                if (nameProducts[0].Type == ProductType.Beer || nameProducts[0].Type == ProductType.Wine || nameProducts[0].Type == ProductType.Spirit)
                    vatPrice = (item.Amount * nameProducts[0].Price) * AlcVAT;
                else
                    vatPrice = (item.Amount * nameProducts[0].Price) * VAT;
            }
        }

        private void DisplayPrice()
        {
            orderViewPriceLbl.Text = $"Total: {price.ToString("C")}";
            orderViewVATLbl.Text = $"VAT: {vatPrice.ToString("C")}";
        }

        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderViewLunch = new OrderViewLunch(items, order, products, employeeName);
            orderViewLunch.Show();
            this.Hide();
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            OrderViewDinner orderViewDinner = new OrderViewDinner(items, order, products, employeeName);
            orderViewDinner.Show();
            this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            OrderViewDrinks orderViewDrinks = new OrderViewDrinks(items, order, products, employeeName);
            orderViewDrinks.Show();
            this.Hide();
        }

        private void orderViewPayBtn_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                InsertOrder();
                InsertOrderItems();
                ChangeStock();
                ChangeForm();
            }
            else
                ChangeForm(); // if no orders are added go back to login

        }

        private void InsertOrderItems()
        {
            OrderItemService service = new OrderItemService();
            service.InsertOrderItems(items);
        }

        private void InsertOrder()
        {
            OrderService service = new OrderService();
            service.InsertOrder(order);
        }

        private void ChangeStock()
        {
            ProductService service = new ProductService();
            List<Product> productCopy = service.GetAllProducts();
            List<Product> updatedStockProducts = new List<Product>();

            foreach (Product product in products)
            {
                bool shouldAdd = true;
                foreach (Product _product in productCopy)
                {
                    if (product.Stock == _product.Stock)
                    {
                        shouldAdd = false;
                        break;
                    }
                }

                if (shouldAdd)
                {
                    updatedStockProducts.Add(product);
                }
            }

            service.UpdateProductStockList(updatedStockProducts);
        }

        private void ChangeForm()
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }

        private void OrderViewFinishOrder_Load(object sender, EventArgs e)
        {
            orderViewTableLbl.Text = $"TABLE: {order.TableId}";
            nameLbl.Text = employeeName;
        }
    }
}
