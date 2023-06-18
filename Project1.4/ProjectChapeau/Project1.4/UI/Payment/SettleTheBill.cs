using Project1._4.DAL;
using Project1._4.Model;
using Project1._4.UI.Payment;
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
    public partial class SettleTheBill : Form
    {
        private string table = "payment";
        private paymentSelected paymentSelected { get; set; }
        private decimal CustomTip { get; set; }

        private decimal AmountPaid { get; set; }

        private decimal orderPrice { get; set; }
        public SettleTheBill(paymentSelected paymentSelected, decimal CustomTip, decimal AmountPaid, decimal orderPrice)
        {
            InitializeComponent();
            this.orderPrice = orderPrice;
            this.paymentSelected = new paymentSelected(orderPrice);
            this.CustomTip = CustomTip;
            this.AmountPaid = AmountPaid;
           
        }

        private void goBackToTableForm_Click(object sender, EventArgs e)
        {
          /*  OrderDao orderDao = new OrderDao();
            int tableId = 1;
            List<OrderItem> orderItems = orderDao.DeleteOrder(tableId);*/
            
            
            TableView tafelOverzicht = new TableView(table);
            tafelOverzicht.Show();

            this.Hide();
        }

        private void SettleTheBill_Load(object sender, EventArgs e)
        {
            // label voor order prijs
            OrderDao orderDao = new OrderDao();
            int tableId = 1;
            List<OrderItem> orderItems = orderDao.GetOrdersFromTable(tableId);

            orderPriceLabelSettle.Text = paymentSelected.OrderPrice.ToString("C"); // c is voor euro teken en twee decimalen
            decimal totalOrderPrice = orderPrice;

            amountPaidSettle.Text = AmountPaid.ToString("C");

            // label voor tip prijs
            TipAmountLabels.Text = CustomTip.ToString("C");

            if (CustomTip == 0)
            {
               
                TipAmountLabels.Text = CustomTip.ToString("C0");
            }

            // label voor amount paid
           


        }

        
    }
}
