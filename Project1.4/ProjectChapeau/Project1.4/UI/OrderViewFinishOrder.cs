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

        private decimal price;
        private decimal vatPrice;

        const decimal AlcVAT = 0.21M;
        const decimal VAT = 0.09M;

        public OrderViewFinishOrder(List<OrderItem> items, Order order) // todo table + employee name
        {
            InitializeComponent();
            this.items = items;
            this.order = order;
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
            OrderViewLunch orderViewLunch = new OrderViewLunch(items, order);
            orderViewLunch.Show();
            this.Hide();
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            //OrderViewDinner orderViewDinner = new OrderViewDinner(items, order);
            //orderViewDinner.Show();
            //this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            //OrderViewDrinks orderViewDrinks = new OrderViewDrinks(items, order);
            //orderViewDrinks.Show();
            //this.Hide();
        }

        private void orderViewPayBtn_Click(object sender, EventArgs e)
        {
            // TODO Insert to orderItems
            // TODO Insert to orders
            // TODO Change Stock Amount
        }
    }
}
