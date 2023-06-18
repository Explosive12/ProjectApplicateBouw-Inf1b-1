using Microsoft.IdentityModel.Tokens;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1._4
{
    public partial class BarOrderControl : UserControl
    {
        private int clickedData; // Stores the ID of the clicked data
        private OrderItem barOrder; // Represents the current bar order
        private OrderStatusEnum state; // Represents the state of the bar order

        public BarOrderControl()
        {
            InitializeComponent();
        }

        // Method to display bar orders in the ListView control
        public void DisplayBarOrders(List<OrderItem> barOrderItems)
        {
            listViewBarOrders.Items.Clear();

            foreach (OrderItem orderItem in barOrderItems)
            {
                TimeSpan waitingTime = DateTime.Now - orderItem.BeginTime;

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
                listViewBarOrders.Items.Add(li);
            }

            // Check if "Running" and "Finished" options are already in the ComboBox
            if (!cbxStatusBar.Items.Contains("Running"))
            {
                cbxStatusBar.Items.Add("Running");
            }
            if (!cbxStatusBar.Items.Contains("Finished"))
            {
                cbxStatusBar.Items.Add("Finished");
            }
        }

        // Button click event handler for marking an order as in preparation
        private void btnPreparationBar_Click(object sender, EventArgs e)
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        // Button click event handler for marking an order as prepared
        private void btnPreparedBar_Click(object sender, EventArgs e)
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

                //to instant update the label
                lblStatusOfDish.Text = OrderStatusEnum.Prepared.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        // Button click event handler for marking an order as served
        private void btnServedBar_Click(object sender, EventArgs e)
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        // Method to update the state of the bar order in the database
        private void ChangeStateDatabase(int stateInt)
        {
            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, stateInt);
        }

        // ListView selection changed event handler
        private void listViewBarOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBarOrders.SelectedItems.Count > 0)
            {
                OrderItemService orderItemService = new OrderItemService();

                ListViewItem selectedItem = listViewBarOrders.SelectedItems[0];
                clickedData = int.Parse(selectedItem.Text); // Assuming the clicked data is in the first column

                List<OrderItem> orderItems = orderItemService.GetByOrderItemId(clickedData);

                if (orderItems.Count > 0)
                {
                    OrderItem selectedOrderItem = orderItems[0]; // Assuming you want to access the first item in the list
                    lblSelectedOrder.Text = selectedOrderItem.OrderItemId.ToString();
                    lblStatusOfDish.Text = selectedOrderItem.Status.ToString();
                }
            }
        }

        // Button click event handler for filtering orders by status
        private void btnFilterByStatusBar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxStatusBar.SelectedItem == null)
                {
                    throw new Exception("No data selected in combobox");
                }

                string selectedValue = cbxStatusBar.SelectedItem.ToString();

                OrderItemService orderItemService = new OrderItemService();
                List<OrderItem> orders;

                if (selectedValue == "Running")
                {
                    orders = orderItemService.GetByStatusBar((int)OrderStatusEnum.Inpreparation);
                }
                else if (selectedValue == "Finished")
                {
                    orders = orderItemService.GetByStatusBar((int)OrderStatusEnum.Prepared);
                    orders.AddRange(orderItemService.GetByStatusBar((int)OrderStatusEnum.Served));
                }
                else
                {
                    return;
                }

                // Display the filtered orders
                DisplayBarOrders(orders);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
