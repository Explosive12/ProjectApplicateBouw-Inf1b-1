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
        public decimal CustomTip { get; set; }

        public decimal AmountPaid { get; set; }

        private decimal orderPrice;
        public commentOrContinuePayment(decimal CustomTip, decimal AmountPaid) // van vorige vorm meegeven
        {
            InitializeComponent();
            this.CustomTip = CustomTip; 
            this.AmountPaid = AmountPaid;
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            commentPayment commentPayment = new commentPayment(CustomTip, AmountPaid);

            commentPayment.Show();
            this.Hide();
        }
      
        private void buttonContinuePayment_Click(object sender, EventArgs e)
        {
            paymentSelected paymentSelected = new paymentSelected(orderPrice);
            SettleTheBill settleTheBill = new SettleTheBill(paymentSelected, CustomTip, AmountPaid, orderPrice);
            settleTheBill.Show();
            this.Hide();
        }
    }
}
