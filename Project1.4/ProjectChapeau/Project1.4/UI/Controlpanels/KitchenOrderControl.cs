using Microsoft.Graph.Models;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1._4
{
    public partial class KitchenOrderControl : UserControl
    {
        private int clickedData; // Stores the ID of the clicked data
        private OrderItem kitchenOrder; // Represents the current kitchen order
        private OrderStatusEnum state; // Represents the state of the kitchen order

        public KitchenOrderControl()
        {
            InitializeComponent();
        }

        // Method to display kitchen orders in the ListView control
        public void DisplayKitchenOrders(List<OrderItem> kitchenOrderItems)
        {
            listViewKitchenOrders.Items.Clear();

            foreach (OrderItem orderItem in kitchenOrderItems)
            {
                TimeSpan waitingTime = DateTime.Now - orderItem.BeginTime;

                // Create a new ListViewItem with the OrderItemId as the first column
                ListViewItem li = new ListViewItem(orderItem.OrderItemId.ToString());
                li.SubItems.Add(orderItem.TableNumber.ToString());
                li.SubItems.Add(orderItem.BeginTime.ToString("HH:mm:ss"));

                // Check if the order is from today
                if (orderItem.BeginTime.Date == DateTime.Now.Date)
                {
                    if (orderItem.Status == OrderStatusEnum.Prepared || orderItem.Status == OrderStatusEnum.Served)
                    {
                        li.SubItems.Add("--:--:--");
                    }
                    else if (orderItem.Status == OrderStatusEnum.Inpreparation)
                    {
                        li.SubItems.Add(waitingTime.ToString(@"hh\:mm\:ss"));
                    }
                    else
                    {
                        // The order is not InPreparation, Prepared, or Served, so skip displaying it.
                        continue;
                    }
                }
                else
                {
                    // The order is not from today, so skip displaying it.
                    continue;
                }

                li.SubItems.Add(orderItem.OrderId.ToString());
                li.SubItems.Add(orderItem.Amount.ToString());
                li.SubItems.Add(orderItem.Comment);

                // Set the Tag property of the ListViewItem to the OrderItem object itself
                li.Tag = orderItem;

                // Add the ListViewItem to the ListView control
                listViewKitchenOrders.Items.Add(li);
            }

            // Check if "Running" and "Finished" options are already in the ComboBox
            if (!cbxStatusKitchen.Items.Contains("Running"))
            {
                cbxStatusKitchen.Items.Add("Running");
            }
            if (!cbxStatusKitchen.Items.Contains("Finished"))
            {
                cbxStatusKitchen.Items.Add("Finished");
            }
        }

        // Button click event handler for marking an order as prepared
        private void btnPreparedKitchen_Click(object sender, EventArgs e)
        {
            try
            {
                if (clickedData == 0)
                {
                    throw new Exception("No data selected");
                }
                state = OrderStatusEnum.Prepared;
                int stateInt = (int)state;
                ChangeStateDatabase(stateInt);

                lblStatusOfDish.Text = OrderStatusEnum.Prepared.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button click event handler for marking an order as served
        private void btnServedKitchen_Click(object sender, EventArgs e)
        {
            try
            {
                if (clickedData == 0)
                {
                    throw new Exception("No data selected");
                }

                state = OrderStatusEnum.Served;
                int stateInt = (int)state;
                ChangeStateDatabase(stateInt);

                //to instant update the label
                lblStatusOfDish.Text = OrderStatusEnum.Served.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button click event handler for marking an order as in preparation
        private void btnPreparationKitchen_Click(object sender, EventArgs e)
        {
            try
            {
                if (clickedData == 0)
                {
                    throw new Exception("No data selected");
                }
                state = OrderStatusEnum.Inpreparation;
                int stateInt = (int)state;

                ChangeStateDatabase(stateInt);

                //to instant update the label
                lblStatusOfDish.Text = OrderStatusEnum.Inpreparation.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to update the state of the kitchen order in the database
        private void ChangeStateDatabase(int stateInt)
        {
            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, stateInt);
        }

        // ListView selection changed event handler
        private void listViewKitchenOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewKitchenOrders.SelectedItems.Count > 0)
            {
                OrderItemService orderItemService = new OrderItemService();

                ListViewItem selectedItem = listViewKitchenOrders.SelectedItems[0];
                clickedData = int.Parse(selectedItem.Text);

                List<OrderItem> orderItems = orderItemService.GetByOrderItemId(clickedData);

                if (orderItems.Count > 0)
                {
                    OrderItem selectedOrderItem = orderItems[0];
                    lblSelectedOrder.Text = selectedOrderItem.OrderItemId.ToString();
                    lblStatusOfDish.Text = selectedOrderItem.Status.ToString();
                }
            }
        }
        // Button click event handler for filtering orders by status
        private void btnFilterByStatusKitchen_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxStatusKitchen.SelectedItem == null)
                {
                    throw new Exception("No data selected in combobox");
                }
                string selectedValue = cbxStatusKitchen.SelectedItem.ToString();
                OrderItemService orderItemService = new OrderItemService();
                List<OrderItem> orders;
                if (selectedValue == "Running")
                {
                    orders = orderItemService.GetByStatusKitchen((int)OrderStatusEnum.Inpreparation);
                }
                else if (selectedValue == "Finished")
                {
                    orders = orderItemService.GetByStatusKitchen((int)OrderStatusEnum.Prepared);
                    orders.AddRange(orderItemService.GetByStatusKitchen((int)OrderStatusEnum.Served));
                }
                else
                {
                    return;
                }

                // Display the filtered orders
                DisplayKitchenOrders(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
