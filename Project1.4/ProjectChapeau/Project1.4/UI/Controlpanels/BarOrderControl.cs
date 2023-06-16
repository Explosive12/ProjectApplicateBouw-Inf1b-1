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
        private int clickedData;
        private OrderItem barOrder;
        private OrderStatusEnum state;

        public BarOrderControl(OrderItem barOrder)
        {
            InitializeComponent();
            this.barOrder = barOrder;
        }

        public void DisplayBarOrders(List<OrderItem> barOrderItems)
        {

            //Clear the ListView control before adding new items
            listViewBarOrders.Items.Clear();

            //Iterate over each CashRegister object in the list and create a new ListViewItem to display its data
            foreach (OrderItem orderItem in barOrderItems)
            {
                TimeSpan waitingTime = DateTime.Now - orderItem.BeginTime;

                //Create a new ListViewItem with the student ID as the first column
                ListViewItem li = new ListViewItem(orderItem.OrderItemId.ToString());

                //Add additional sub-items to the ListViewItem for the student's first and last name, the drink name, and the order date
                li.SubItems.Add(orderItem.OrderId.ToString());
                li.SubItems.Add(orderItem.Amount.ToString());
                li.SubItems.Add(orderItem.Comment);
                li.SubItems.Add(waitingTime.ToString(@"hh\:mm\:ss"));

                //Set the Tag property of the ListViewItem to the CashRegister object itself
                li.Tag = orderItem;

                //Add the ListViewItem to the ListView control
                listViewBarOrders.Items.Add(li);


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
        }

        private void btnPreparationBar_Click(object sender, EventArgs e)
        {
            state = OrderStatusEnum.Inpreparation;
            int stateInt = (int)state;

            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, stateInt);

            //to instant update the label
            lblStatusOfDish.Text = OrderStatusEnum.Inpreparation.ToString();
        }

        private void btnPreparedBar_Click(object sender, EventArgs e)
        {
            state = OrderStatusEnum.Prepared;
            int stateInt = (int)state;

            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, stateInt);

            //to instant update the label
            lblStatusOfDish.Text = OrderStatusEnum.Prepared.ToString();
        }

        private void btnServedBar_Click(object sender, EventArgs e)
        {
            state = OrderStatusEnum.Served;
            int stateInt = (int)state;

            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, stateInt);

            //to instant update the label
            lblStatusOfDish.Text = OrderStatusEnum.Served.ToString();
        }

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
        private void btnFilterByStatusBar_Click(object sender, EventArgs e)
        {
            if (cbxStatusBar.SelectedItem != null)
            {
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
                    // Handle unknown status or error
                    return;
                }

                DisplayBarOrders(orders);
            }
        }
    }
}
