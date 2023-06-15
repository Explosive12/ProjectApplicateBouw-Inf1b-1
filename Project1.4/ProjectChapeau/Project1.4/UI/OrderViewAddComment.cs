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
        public OrderViewAddComment(string orderView, OrderItem orderItem)
        {
            InitializeComponent();
            this.orderView = orderView;
            this.orderItem = orderItem;
        }

        private void orderViewCommentAddBtn_Click(object sender, EventArgs e)
        {
            if (CommentTxtBox.Text.Length > 0)
                orderItem.Comment = CommentTxtBox.Text;

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
                    OrderViewLunch orderViewLunch = new OrderViewLunch();
                    orderViewLunch.Show();
                    this.Hide();
                    break;
                case "Dinner":
                    OrderViewDinner orderViewDinner = new OrderViewDinner();
                    orderViewDinner.Show();
                    this.Hide();
                    break;
                case "Drinks":
                    OrderViewDrinks orderViewDrinks = new OrderViewDrinks();
                    orderViewDrinks.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
