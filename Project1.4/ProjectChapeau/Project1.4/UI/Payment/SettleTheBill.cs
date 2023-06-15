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
        public SettleTheBill()
        {
            InitializeComponent();
        }

        private void goBackToTableForm_Click(object sender, EventArgs e)
        {
            TableView tafelOverzicht = new TableView();
            tafelOverzicht.Show();

            this.Hide();
        }

        private void SettleTheBill_Load(object sender, EventArgs e)
        {
            LoadAllPaymentData();
        }

        private void LoadAllPaymentData()
        {

        }
    }
}
