using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI.Payment
{
    public partial class finishBill : Form
    {
        public finishBill()
        {
            InitializeComponent();
        }

        private void billLabel_Click(object sender, EventArgs e)
        {

        }

        private void proceedPayment_Click(object sender, EventArgs e)
        {
            paymentSelected paymentSelect = new paymentSelected();
            finishBill finishBill = new finishBill();

            paymentSelect.Show();
            this.Hide();
        }
    }
}
