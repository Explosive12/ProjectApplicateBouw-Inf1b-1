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
    public partial class commentPayment : Form
    {

        /*     private Timer timer;*/



        public commentPayment()
        {
            InitializeComponent();
            /* timer = new Timer();
             timer.Interval = 5000; // 5 seconds
             timer.Tick += Timer_Tick;*/


        }

        private async void confirmPayment_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(commentCustomerBox.Text))
            {
                commentHasBeenSaved.Text = "COMMENT HAS BEEN SAVED";
                await Task.Delay(3000); // Delay for 3 seconds
                SettleTheBill settleForm = new SettleTheBill();
                settleForm.Show();
            }
            else if (string.IsNullOrEmpty(commentCustomerBox.Text))
            {
                commentHasBeenSaved.Text = "PLEASE ENTER A COMMENT";
                commentHasBeenSaved.ForeColor = Color.Red;

            }



        }

        private void backToCommentOrContinue_Click(object sender, EventArgs e)
        {
            commentOrContinuePayment commentOrContinue = new commentOrContinuePayment();

            commentOrContinue.Show();
            this.Hide();
        }

        private void commentCustomerBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
