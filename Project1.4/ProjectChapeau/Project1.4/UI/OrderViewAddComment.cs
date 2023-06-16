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
        public OrderViewAddComment(string orderView, OrderItem orderItem, List<OrderItem> items, Order order) // TODO receive table ID / Employee name
        {
            InitializeComponent();
            this.orderView = orderView;
            this.orderItem = orderItem;
            this.order = order;
            this.items = items;
        }

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
                    OrderViewLunch orderViewLunch = new OrderViewLunch(items, order);
                    orderViewLunch.Show();
                    this.Hide();
                    break;
                case "Dinner":
                    //OrderViewDinner orderViewDinner = new OrderViewDinner();
                   // orderViewDinner.Show();
                    this.Hide();
                    break;
                case "Drinks":
                   // OrderViewDrinks orderViewDrinks = new OrderViewDrinks();
                   // orderViewDrinks.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
