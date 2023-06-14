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
    public partial class OrderViewDinner : Form
    {
        public OrderViewDinner()
        {
            InitializeComponent();
        }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            OrderViewDinner orderView = new OrderViewDinner();
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            OrderViewDrinks orderView = new OrderViewDrinks();
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderView = new OrderViewLunch();
            orderView.Show();
            this.Hide();
        }
    }
}
