using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project1._4.UI
{
    public partial class BarKitchenView : Form
    {
        private System.Windows.Forms.Timer kitchenOrdersTimer;

        //private Order order = new Order();
        public BarKitchenView()
        {
            InitializeComponent();

            kitchenOrdersTimer = new System.Windows.Forms.Timer();
            kitchenOrdersTimer.Interval = 1000; // 1 minute = 60,000 milliseconds
            kitchenOrdersTimer.Tick += new EventHandler(btnLoadKitchenOrders_Click);
            kitchenOrdersTimer.Start();
        }
        public void Loadabc()
        {
            List<OrderItem> kitchenOrders = GetKitchenOrders();

            this.flpKitchenOrders.Controls.Clear();

            foreach (OrderItem kitchenOrder in kitchenOrders)
            {
                KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);
                this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
            }

        }

        private void btnLoadKitchenOrders_Click(object sender, EventArgs e)
        {
            List<OrderItem> kitchenOrders = GetKitchenOrders();

            this.flpKitchenOrders.Controls.Clear();

            if (kitchenOrders.Count == 0)
            {
                MessageBox.Show("No orders in list");
            }
            foreach (OrderItem kitchenOrder in kitchenOrders)
            {
                KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);
                this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
            }

            ShowCashRegistersPanel();
        }

        private void btnKitchenToMain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            // Create an instance of the new form
            LoginView loginview = new LoginView();
            BarKitchenView barKitchenView = new BarKitchenView();

            // Show the new form
            form1.Show();
            this.Hide();
        }

        public void ShowCashRegistersPanel()
        {
            try
            {
                List<OrderItem> kitchenOrderItems = GetKitchenOrderItems();

                this.flpKitchenOrders.Controls.Clear();

                foreach (OrderItem order in kitchenOrderItems)
                {
                    KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(order);
                    kitchenOrderControl.DisplayKitchenOrders(kitchenOrderItems);
                    this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }
        private List<OrderItem> GetKitchenOrders()
        {
           OrderItemService orderItemService = new OrderItemService();
           List<OrderItem> orders = orderItemService.GetOrderItemsByDinnerLunch();
           return orders;
        }
        private List<OrderItem> GetKitchenOrderItems()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetOrderItemsByDinnerLunch();
            return orderItems;
        }
    }
}
