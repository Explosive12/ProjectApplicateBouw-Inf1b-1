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
        public BarKitchenView()
        {
            InitializeComponent();
        }

        private void btnLoadKitchenOrders_Click(object sender, EventArgs e)
        {
            List<OrderItem> kitchenOrders = GetKitchenOrders();

            this.flpOrders.Controls.Clear();

            if (kitchenOrders.Count == 0)
            {
                MessageBox.Show("No orders in list");
            }
            else
            {
                foreach (OrderItem kitchenOrder in kitchenOrders)
                {
                    KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);
                    this.flpOrders.Controls.Add(kitchenOrderControl);
                }

                ShowKitchenControl();
            }
        }
        private void btnLoadBarOrders_Click(object sender, EventArgs e)
        {
            List<OrderItem> barOrders = GetBarOrders();

            this.flpOrders.Controls.Clear();

            if (barOrders.Count == 0)
            {
                MessageBox.Show("No orders in list");
            }
            else
            {
                foreach (OrderItem barOrder in barOrders)
                {
                    BarOrderControl barOrderControl = new BarOrderControl(barOrder);
                    this.flpOrders.Controls.Add(barOrderControl);
                }

                ShowBarControl();
            }
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

        public void ShowKitchenControl()
        {
            try
            {
                List<OrderItem> kitchenOrderItems = GetKitchenOrderItems();

                this.flpOrders.Controls.Clear();

                foreach (OrderItem order in kitchenOrderItems)
                {
                    KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(order);
                    kitchenOrderControl.DisplayKitchenOrders(kitchenOrderItems);
                    this.flpOrders.Controls.Add(kitchenOrderControl);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }
        public void ShowBarControl()
        {
            try
            {
                List<OrderItem> barOrderItems = GetBarOrderItems();

                this.flpOrders.Controls.Clear();

                foreach (OrderItem order in barOrderItems)
                {
                    BarOrderControl barOrderControl = new BarOrderControl(order);
                    barOrderControl.DisplayBarOrders(barOrderItems);
                    this.flpOrders.Controls.Add(barOrderControl);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }

        private List<OrderItem> GetKitchenOrderItems()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetOrderItemsByDinnerLunch();
            return orderItems;
        }
        private List<OrderItem> GetBarOrderItems()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetOrderItemsByDrink();
            return orderItems;
        }
        private List<OrderItem> GetKitchenOrders()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orders = orderItemService.GetOrderItemsByDinnerLunch();
            return orders;
        }
        private List<OrderItem> GetBarOrders()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orders = orderItemService.GetOrderItemsByDrink();
            return orders;
        }
    }
}
