using Project1._4.Model;
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
    public partial class OrderViewDrinkUC : UserControl
    {
        // Ik had in de tijd van schrijven geen idee hoe ik geen duplicate code moest hebben met de usercontrol
        private Product product;
        private OrderViewDrinks orderview;

        public OrderViewDrinkUC(Product product, OrderViewDrinks orderView)
        {
            InitializeComponent();
            priceLbl.Text = product.Price.ToString();
            productLbl.Text = product.Name.ToString();
            this.product = product;
            this.orderview = orderView;
        }

        private void UCButton_Click(object sender, EventArgs e)
        {
            ButtonAction();
        }

        private void productLbl_Click(object sender, EventArgs e)
        {
            ButtonAction();
        }

        private void priceLbl_Click(object sender, EventArgs e)
        {
            ButtonAction();
        }

        private void ButtonAction()
        {
            orderview.AddProductToOrderItem(product);
            orderview.DisplayOrderItems();
        }
    }
}
