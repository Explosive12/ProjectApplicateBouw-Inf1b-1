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
        }
        private void KitchenOrderControll_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            lblBestelregelIdKitchen.Text = kitchenOrder.OrderId.ToString();
            lblCountKitchen.Text = kitchenOrder.TableId.ToString();
            lblCountKitchen.Text = string.Empty;
            lblDescriptionKitchen.Text = string.Empty;
        }
    }
}
