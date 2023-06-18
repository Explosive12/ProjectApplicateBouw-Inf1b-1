using Microsoft.Graph.Models;
using Project1._4.DAL;
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
using System.Windows.Forms;

namespace Project1._4.UI.Payment
{
    public partial class finishBill : Form
    {
        private decimal orderPrice;

        private string table = "payment";

        public finishBill()
        {
            InitializeComponent();
        }

        private void billLabel_Click(object sender, EventArgs e)
        {

        }

        private void proceedPayment_Click(object sender, EventArgs e)
        {
            if (radioButtonVisa.Checked || DEBITRadio.Checked)
            {
                paymentSelected paymentSelect = new paymentSelected(orderPrice);
                finishBill finishBill = new finishBill();
                paymentSelect.Show();
                this.Hide();
            }
            else if (radioButtonCash.Checked)
            {
                radioButtonCash.BackColor = Color.Orange;

                TableView tafelOverzicht = new TableView(table);
                tafelOverzicht.Show();
            }


        }

        private void DEBITRadio_CheckedChanged(object sender, EventArgs e)
        {
            DEBITRadio.BackColor = Color.Orange;
            radioButtonCash.BackColor = DefaultBackColor;
            radioButtonVisa.BackColor = DefaultBackColor;

        }

        private void radioButtonVisa_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonVisa.BackColor = Color.Orange;
            radioButtonCash.BackColor = DefaultBackColor;
            DEBITRadio.BackColor = DefaultBackColor;

        }



        private void radioButtonCash_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButtonCash.BackColor = Color.Orange;
            radioButtonVisa.BackColor = DefaultBackColor;
            DEBITRadio.BackColor = DefaultBackColor;

        }

       

        private decimal CalculateTotalPrice(List<OrderItem> orderItems)
        {
            OrderService orderService = new OrderService();
            
            decimal totalPrice = 0;

            foreach (OrderItem item in orderItems)
            {


                
                decimal productPrice = orderService.GetProductPrice(item.ProductId); // Prijs van het product ophalen
                int quantity = orderService.QuantityOfProduct(item.ProductId); // Aantal van het product ophalen

                decimal itemTotalPrice = productPrice * quantity; // Bereken de totaalprijs van het item

                totalPrice += itemTotalPrice;
            }

            return totalPrice;
        }
        private void finishBill_Load(object sender, EventArgs e)
        {
            OrderDao orderDao = new OrderDao();
            int tableId = 1;
            List<OrderItem> orderItems = orderDao.GetOrdersFromTable(tableId);
           
            

            decimal totalOrderPrice = CalculateTotalPrice(orderItems);

            totalPriceCalculate.Text = totalOrderPrice.ToString("C"); // C is euro currency


            




        }

    
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
