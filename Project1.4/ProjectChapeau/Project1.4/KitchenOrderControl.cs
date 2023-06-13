using Microsoft.Graph.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnPreparedKitchen_Click(object sender, EventArgs e)
        {
            Update();

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


















            //          //Clear the ComboBoxes for students and drinks before repopulating them with updated data
            //          cbxStudent.Items.Clear();
            //          List<Student> students = GetStudents();
            //          
            //          //Iterate over each Student object in the list and add its first name to the ComboBox (with the ID included in the item's value)
            //          foreach (Student student in students)
            //          {
            //              if (!cbxStudent.Items.Contains(student.Firstname))
            //              {
            //                  cbxStudent.Items.Add($"{student.StudentID} {student.Firstname}");
            //              }
            //          }
            //          
            //          //Repeat the same process for the list of drinks
            //          cbxDrink.Items.Clear();
            //          List<Drink> drinks = GetDrinks();
            //          foreach (Drink drink in drinks)
            //          {
            //              if (!cbxDrink.Items.Contains($"{drink.DrinkID}"))
            //              {
            //                  cbxDrink.Items.Add($"{drink.DrinkID} {drink.DrinkName}");
            //              }
            //          }
        }

        private void listViewKitchenOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKitchenOrders.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewKitchenOrders.SelectedItems[0];
                string clickedData = selectedItem.Text; // Assuming the clicked data is in the first column

                // Use the clickedData as required
                MessageBox.Show($"You clicked: {clickedData}");
            }

        }
    }
}
