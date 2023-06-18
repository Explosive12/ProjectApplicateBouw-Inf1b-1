using Microsoft.Graph.Models;
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

        // Button click event handler for loading kitchen orders
        private void btnLoadKitchenOrders_Click(object sender, EventArgs e)
        {
            // Get the list of kitchen orders
            List<OrderItem> kitchenOrders = GetKitchenOrders();

            // Clear the container for displaying orders
            this.flpOrders.Controls.Clear();

            // Check if there are any orders
            if (kitchenOrders.Count == 0)
            {
                MessageBox.Show("No orders in list");
            }
            else
            {
                KitchenOrderControl kitchenOrderControl = new KitchenOrderControl();
                this.flpOrders.Controls.Add(kitchenOrderControl);

                // Show the kitchen control
                ShowKitchenControl();
            }
        }

        // Button click event handler for loading bar orders
        private void btnLoadBarOrders_Click(object sender, EventArgs e)
        {
            // Get the list of bar orders
            List<OrderItem> barOrders = GetBarOrders();

            // Clear the container for displaying orders
            this.flpOrders.Controls.Clear();

            // Check if there are any orders
            if (barOrders.Count == 0)
            {
                MessageBox.Show("No orders in list");
            }
            else
            {
                BarOrderControl barOrderControl = new BarOrderControl();
                this.flpOrders.Controls.Add(barOrderControl);

                // Show the bar control
                ShowBarControl();
            }
        }
        // Button click event handler for navigating back to the main form
        private void btnKitchenToMain_Click(object sender, EventArgs e)
        {
            // Create an instance of the main form
            Form1 form1 = new Form1();
            // Create an instance of the login view form
            LoginView loginview = new LoginView();
            // Create an instance of the bar kitchen view form
            BarKitchenView barKitchenView = new BarKitchenView();

            // Show the main form and hide the current form
            form1.Show();
            this.Hide();
        }

        // Method to display kitchen orders
        public void ShowKitchenControl()
        {
            try
            {
                // Get the list of kitchen order items
                List<OrderItem> kitchenOrderItems = GetKitchenOrderItems();

                // Clear the container for displaying orders
                this.flpOrders.Controls.Clear();

                KitchenOrderControl kitchenOrderControl = new KitchenOrderControl();

                // Display the kitchen orders using the control
                kitchenOrderControl.DisplayKitchenOrders(kitchenOrderItems);
                this.flpOrders.Controls.Add(kitchenOrderControl);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }

        // Method to display bar orders
        public void ShowBarControl()
        {
            try
            {
                List<OrderItem> barOrderItems = GetBarOrderItems();

                // Clear the container for displaying orders
                this.flpOrders.Controls.Clear();

                BarOrderControl barOrderControl = new BarOrderControl();

                // Display the bar orders using the control
                barOrderControl.DisplayBarOrders(barOrderItems);
                this.flpOrders.Controls.Add(barOrderControl);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }

        // Method to get kitchen order items
        private List<OrderItem> GetKitchenOrderItems()
        {
            OrderItemService orderItemService = new OrderItemService();
            // Get the list of order items related to dinner/lunch for the bar
            List<OrderItem> orderItems = orderItemService.GetOrderItemsByDinnerLunch();
            return orderItems;
        }

        // Method to get bar order items
        private List<OrderItem> GetBarOrderItems()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orderItems = orderItemService.GetOrderItemsByDrink();
            return orderItems;
        }

        // Method to get kitchen orders
        private List<OrderItem> GetKitchenOrders()
        {
            OrderItemService orderItemService = new OrderItemService();
            // Get the list of orders related to dinner/lunch for the kitchen
            List<OrderItem> orders = orderItemService.GetOrderItemsByDinnerLunch();
            return orders;
        }

        // Method to get bar orders
        public List<OrderItem> GetBarOrders()
        {
            OrderItemService orderItemService = new OrderItemService();
            List<OrderItem> orders = orderItemService.GetOrderItemsByDrink();
            return orders;
        }
    }
}
