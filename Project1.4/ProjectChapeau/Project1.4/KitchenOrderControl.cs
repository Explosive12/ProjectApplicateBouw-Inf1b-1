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

namespace Project1._4
{
    public partial class KitchenOrderControl : UserControl
    {
        private Order kitchenOrder;

        public Order KitchenOrder
        {
            get { return kitchenOrder; }
        }
        public KitchenOrderControl(Order kitchenOrder)
        {
            InitializeComponent();
            this.kitchenOrder = kitchenOrder;
            UpdateLabels();
        }
        private void KitchenOrderControll_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            Random random = new Random();

            lblBestelregelIdKitchen.Text = kitchenOrder.OrderId.ToString();
            lblOrderIdKitchen.Text = random.Next(1, 100).ToString();
            lblCountKitchen.Text = random.Next(1, 100).ToString();
            lblDescriptionKitchen.Text = random.Next(1, 100).ToString();
            lblStatusOfDish.Text = random.Next(1, 100).ToString();

            //cbxOrderStatusKitchen.Items.Clear();

            List<Order> orders = GetOrders();
            foreach (Order order in orders)
            {
                if (!cbxOrderStatusKitchen.Items.Contains($"{order.OrderId}"))
                {
                    cbxOrderStatusKitchen.Items.Add($"{order.OrderId} {order.}")
                }
            }
        }

        private void btnPreparedKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to prepared and make it so the button checks if there is data in the select combobox
        }

        private void btnServedKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to Served and make it so the button checks if there is data in the select combobox
        }

        private void btnPreparationKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to preparation and make it so the button checks if there is data in the select combobox
        }
    }
}
