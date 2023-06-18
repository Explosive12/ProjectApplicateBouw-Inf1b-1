using Project1._4.DAL;
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

namespace Project1._4.UI.Payment
{
    public partial class paymentSelected : Form
    {


        private decimal orderPrice; 
        public decimal OrderPrice { get; set; }

        public decimal CustomTip { get; set; }

        public decimal AmountPaid { get; set; }


        public paymentSelected(decimal orderPrice)
        {
            InitializeComponent();
            this.OrderPrice = orderPrice;
        }
        
        private void paymentSelected_Load(object sender, EventArgs e)
        {
            OrderDao orderDao = new OrderDao();
            int tableId = 1;
            List<OrderItem> orderItems = orderDao.GetOrdersFromTable(tableId);



            decimal totalOrderPrice = OrderPrice;

            totalPriceSelected.Text = totalOrderPrice.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter an amount!");
                return;
            }
            commentOrContinuePayment commentOrContinue = new commentOrContinuePayment(CustomTip, AmountPaid);
            
            commentOrContinue.Show();
            this.Hide();

        }

        private void buttonAddChangeTip_Click(object sender, EventArgs e)
        {

            decimal textBoxCustomTips = decimal.Parse(textBoxCustomTip.Text);

            this.CustomTip = textBoxCustomTips;

            if (textBoxCustomTips < 0)
            {
                MessageBox.Show("A Tip has to be positive!");
                return;
            }


            TipLabelWithChange.Text = textBoxCustomTips.ToString("C");

            LeftOverPriceLabel.Text = "0";



            customTip.Visible = false;
            textBoxCustomTip.Visible = false;

            buttonAddChangeTip.Visible = false;

            tipHasBeenAdded.Text = "HAS BEEN ADDED";
        }

      

        private void buttonSet_Click(object sender, EventArgs e) // amount price
        {
            if(textBoxAmountPaid.Text == "") // lege waarde komt er een text box
            {
                MessageBox.Show("Please enter an amount!");
                return;
            }
            decimal totalPriceSelectedLabel = decimal.Parse(totalPriceSelected.Text);

            //TODO make it so you can only enter numbers
            decimal textBoxAmountPaidTotal = decimal.Parse(textBoxAmountPaid.Text);

            OrderPrice = totalPriceSelectedLabel;
            AmountPaid = textBoxAmountPaidTotal;
            

            if (totalPriceSelectedLabel > textBoxAmountPaidTotal) // bedrag moet groter zijn
            {
                MessageBox.Show("You cannot pay les than the total price!");
                return;
            }
            decimal leftOverPrice = textBoxAmountPaidTotal - totalPriceSelectedLabel;

            LeftOverPriceLabel.Text = leftOverPrice.ToString("C");
        }

       

        private void totalPriceSelected_Click(object sender, EventArgs e)
        {
            decimal textBoxCustomTips = decimal.Parse(totalPriceSelected.Text);
        }


    }
}
