using Microsoft.Graph.Models;
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
            if (radioButtonVisa.Checked || DEBITRadio.Checked)
            {
                paymentSelected paymentSelect = new paymentSelected();
                finishBill finishBill = new finishBill();
                paymentSelect.Show();
                this.Hide();
            }
            else if (radioButtonCash.Checked)
            {
                radioButtonCash.BackColor = Color.Orange;

                TableView tafelOverzicht = new TableView();
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

        // constructor om tafel id op te halen
        private void GetTableId()
        {

        }

        private void finishBill_Load(object sender, EventArgs e)
        {
            OrderDao orderDao = new OrderDao();
            int tableId = 1;
            List<OrderItem> orderItems = orderDao.GetOrdersFromTable(tableId);
           
            

            decimal totalOrderPrice = orderDao.CalculateTotalPrice(orderItems);

            totalPriceCalculate.Text = totalOrderPrice.ToString("C");

        /*    foreach (OrderItem item in orderItems)
            {
                
                ListViewItem listViewItem = new ListViewItem(item.id.ToString()); 
                listViewItem.SubItems.Add(item.Na.ToString()); 
                listViewItem.SubItems.Add(item.ProductId.ToString()); 
                listViewItem.SubItems.Add(item.Amount.ToString()); 
                listViewItem.SubItems.Add(item.Opmerking);
                listViewItem.SubItems.Add(item.Status); 

                listView1.Items.Add(listViewItem); 
            }*/
           

        }

        private void LoadBill()
        {

        }

        public void GetTotalPrice()
        {

        }

        private void GetVatPrice()
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
