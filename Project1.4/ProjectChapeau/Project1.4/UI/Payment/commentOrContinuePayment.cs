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
    public partial class commentOrContinuePayment : Form
    {
        public commentOrContinuePayment()
        {
            InitializeComponent();
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            commentPayment commentPayment = new commentPayment();

            commentPayment.Show();
            this.Hide();
        }

        private void buttonContinuePayment_Click(object sender, EventArgs e)
        {
            SettleTheBill settleTheBill = new SettleTheBill();
            settleTheBill.Show();
            this.Hide();
        }
    }
}
