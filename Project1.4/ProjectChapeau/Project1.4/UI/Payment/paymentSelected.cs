﻿using System;
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
    public partial class paymentSelected : Form
    {
        public paymentSelected()
        {
            InitializeComponent();
        }

        private void paymentSelected_Load(object sender, EventArgs e)
        {

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            commentOrContinuePayment commentOrContinue = new commentOrContinuePayment();

            commentOrContinue.Show();
            this.Hide();

        }

        private void buttonAddChangeTip_Click(object sender, EventArgs e)
        {
            customTip.Visible = false;
            textBoxCustomTip.Visible = false;
            setButton1.Visible = false;
            buttonAddChangeTip.Visible = false;

            tipHasBeenAdded.Text = "HAS BEEN ADDED";
        }

        private void GetPaymentPrice()
        {

        }

        private void GetCustomTip()
        {

        }
    }
}
