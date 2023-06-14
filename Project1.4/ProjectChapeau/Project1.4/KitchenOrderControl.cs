using Microsoft.Graph.Models;
using Project1._4.Model;
using Project1._4.Service;
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
        private int clickedData;
        private Order kitchenOrder;
        private string state;

        public Order KitchenOrder
        {
            get { return kitchenOrder; }
        }
        public KitchenOrderControl(Order kitchenOrder)
        {
            InitializeComponent();
            this.kitchenOrder = kitchenOrder;
        }

        private void btnPreparedKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to prepared and make it so the button checks if there is data in the select combobox

            MessageBox.Show($"Clicked data: {clickedData}");


        }

        private void btnServedKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to Served and make it so the button checks if there is data in the select combobox
        }

        private void btnPreparationKitchen_Click(object sender, EventArgs e)
        {
            //TODO update database with the correct status to preparation and MAKE IT SO IF THERE IS NO DATA CLICKED YOU GET EXEPTION
            state = "klaar";

            OrderItemService orderItemService = new OrderItemService();
            orderItemService.UpdateOrderItemStatus(clickedData, state);
        }

        public void DisplayKitchenOrders(List<Order> kitchenOrders, List<OrderItem> kitchenOrderItems)
        {
            //Clear the ListView control before adding new items
            listViewKitchenOrders.Items.Clear();

            //Iterate over each CashRegister object in the list and create a new ListViewItem to display its data
            foreach (OrderItem orderItem in kitchenOrderItems)
            {
                //Create a new ListViewItem with the student ID as the first column
                ListViewItem li = new ListViewItem(orderItem.OrderItemId.ToString());

                //Add additional sub-items to the ListViewItem for the student's first and last name, the drink name, and the order date
                li.SubItems.Add(orderItem.OrderId.ToString());
                li.SubItems.Add(orderItem.Amount.ToString());
                li.SubItems.Add(orderItem.Comment);

                //Set the Tag property of the ListViewItem to the CashRegister object itself
                li.Tag = orderItem;

                //Add the ListViewItem to the ListView control
                listViewKitchenOrders.Items.Add(li);
            }
        }

        private void listViewKitchenOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKitchenOrders.SelectedItems.Count > 0)
            {
                OrderItemService orderItemService = new OrderItemService();
                
                ListViewItem selectedItem = listViewKitchenOrders.SelectedItems[0];
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
    }
}
