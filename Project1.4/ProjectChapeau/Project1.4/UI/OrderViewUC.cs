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

namespace Project1._4
{
    public partial class OrderViewUC : UserControl
    {
        public OrderViewUC(Product product)
        {
            InitializeComponent();
            priceLbl.Text = product.Price.ToString();
            productLbl.Text = product.Name.ToString();

        }

        private void UCButton_Click(object sender, EventArgs e)
        {
            productLbl.Text = "HET WERKT!!!!!!";
        }

        
    }
}
