using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1._4.Model;


namespace Project1._4.UI
{
    public partial class OrderViewAddComment : Form
    {
        private OrderItem orderItem;
        private string orderView;
        private List<OrderItem> items;
        private Order order;
        private List<Product> products;

        public OrderViewAddComment(string orderView, OrderItem orderItem, List<OrderItem> items, Order order, List<Product> products)
        {
            InitializeComponent();
            this.orderView = orderView;
            this.orderItem = orderItem;
            this.order = order;
            this.items = items;
            this.products = products;
        }
        
        // removes orderItem from the list, edits it and then adds it back to the list
        private void orderViewCommentAddBtn_Click(object sender, EventArgs e)
        {
            items.Remove(orderItem);
            if (CommentTxtBox.Text.Length > 0)
                orderItem.Comment = CommentTxtBox.Text;
            this.orderItem = orderItem;
            items.Add(orderItem);
            GoToForm();
        }

        private void orderViewCommentBackBtn_Click(object sender, EventArgs e)
        {
            GoToForm();
        }

        private void GoToForm()
        {
            switch (orderView)
            {
                case "Lunch":
                    OrderViewLunch orderViewLunch = new OrderViewLunch(items, order, products);
                    orderViewLunch.Show();
                    this.Hide();
                    break;
                case "Dinner":
                    OrderViewDinner orderViewDinner = new OrderViewDinner(items, order, products);
                     orderViewDinner.Show();
                    this.Hide();
                    break;
                case "Drinks":
                    OrderViewDrinks orderViewDrinks = new OrderViewDrinks(items, order, products);
                    orderViewDrinks.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
