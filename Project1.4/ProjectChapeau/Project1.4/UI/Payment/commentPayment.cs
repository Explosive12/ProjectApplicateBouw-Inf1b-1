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
using System.Web;
using System.Windows.Forms;

namespace Project1._4.UI.Payment
{
    public partial class commentPayment : Form
    {
        public decimal CustomTip { get; set; }

        public decimal AmountPaid { get; set; }

        private decimal orderPrice;
        /*     private Timer timer;*/



        public commentPayment(decimal CustomTip, decimal AmountPaid) // constructor om dingen mee te geven
        {
            InitializeComponent();
            this.CustomTip = CustomTip;
            this.AmountPaid = AmountPaid;
            


        }

        private async void confirmPayment_Click(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            PaymentItem paymentItem = new PaymentItem();

            paymentItem.Comment = commentCustomerBox.Text;



            int paymentId = paymentItem.BestellingId;
           

            //TODO: make the paymentId and get the current paymentId
            paymentService.AddComment(paymentItem.Comment, paymentId);


            if (string.IsNullOrEmpty(commentCustomerBox.Text))
            {
                commentHasBeenSaved.Text = "PLEASE ENTER A COMMENT";
                commentHasBeenSaved.ForeColor = Color.Red;
            }
            else
            {
                commentHasBeenSaved.Text = "COMMENT HAS BEEN SAVED";
                commentHasBeenSaved.ForeColor = Color.Green;
                //githubupdate

                await Task.Delay(3000);
                // Delay for 3 seconds

                paymentSelected paymentSelected = new paymentSelected(orderPrice);
                SettleTheBill settleTheBill = new SettleTheBill(paymentSelected, CustomTip, AmountPaid, orderPrice); // constructor meegeven
                this.Hide();
                settleTheBill.Show();
            }
        }

        private void backToCommentOrContinue_Click(object sender, EventArgs e)
        {
            commentOrContinuePayment commentOrContinue = new commentOrContinuePayment(CustomTip, AmountPaid);

            commentOrContinue.Show();
            this.Hide();
        }

        private void commentPayment_Load(object sender, EventArgs e)
        {

        }

        private void GetComment()
        {

        }
    }
}
