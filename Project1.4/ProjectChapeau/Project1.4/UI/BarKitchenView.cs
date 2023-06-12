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
        //private Order order = new Order();
        public BarKitchenView()
        {
            InitializeComponent();
        }
        public void Loadabc()
        {
            Order kitchenOrder = GenerateNewKitchenOrder();
            KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);

            this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
        }

        public List<Order> LoadOrders()
        {
            OrderService service = new OrderService();
            List<Order> orders = service.GetAllOrders();
            return orders;
        }

        public List<OrderItem> LoadOrderItems()
        {
            OrderItemService service = new OrderItemService();
            List<OrderItem> orderItems = service.GetAllOrderItems();
            return orderItems;
        }

        private Order GenerateNewKitchenOrder()
        {
            Random random = new Random();

            int orderId = random.Next(0, 100);
            int tableId = random.Next(0, 100);
            DateTime beginTime = DateTime.Now;
            DateTime endTime = DateTime.Now;

            Order kitchenOrder = new Order(orderId, tableId, beginTime, endTime);
            return kitchenOrder;
        }

        private void btnLoadKitchenOrders_Click(object sender, EventArgs e)
        {
            Order kitchenOrder = GenerateNewKitchenOrder();
            KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);

            this.flpKitchenOrders.Controls.Clear();
            this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
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







        private void ShowCashRegistersPanel()
        {
            //HideAllPanels();
            //pnlCashRegister.Show();

            try
            {
                List<BarKitchenView> barKitchenOrders = GetBarKitchenOrders();
                DisplayCashRegisters(barKitchenOrders);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Something went wrong while loading the cash registers: " + e.Message);
            }
        }
        private List<BarKitchenView> GetBarKitchenOrders()
        {
            //Create a new instance of the CashRegisterService
            OrderService orderService = new OrderService();

            //Call the GetCashRegisters method on the service to retrieve a list of CashRegister objects
            List<OrderService> orders = orders.GetCashRegisters();

            return orders;
        }
        private void DisplayCashRegisters(List<BarKitchenView> barKitchenOrders)
        {
            //Clear the ListView control before adding new items
            listViewCashRegisters.Items.Clear();

            //Iterate over each CashRegister object in the list and create a new ListViewItem to display its data
            foreach (CashRegister cashregister in cashregisters)
            {
                //Create a new ListViewItem with the student ID as the first column
                ListViewItem li = new ListViewItem(cashregister.StudentID.ToString());

                //Set the Tag property of the ListViewItem to the CashRegister object itself
                li.Tag = cashregister;

                //Add additional sub-items to the ListViewItem for the student's first and last name, the drink name, and the order date
                li.SubItems.Add(cashregister.Firstname);
                li.SubItems.Add(cashregister.Lastname);
                li.SubItems.Add(cashregister.Drinkname);
                li.SubItems.Add(cashregister.OrderDate.ToString(DateFormatWithoutTime));

                //Add the ListViewItem to the ListView control
                listViewCashRegisters.Items.Add(li);
            }

            //Clear the ComboBoxes for students and drinks before repopulating them with updated data
            cbxStudent.Items.Clear();
            List<Student> students = GetStudents();

            //Iterate over each Student object in the list and add its first name to the ComboBox (with the ID included in the item's value)
            foreach (Student student in students)
            {
                if (!cbxStudent.Items.Contains(student.Firstname))
                {
                    cbxStudent.Items.Add($"{student.StudentID} {student.Firstname}");
                }
            }

            //Repeat the same process for the list of drinks
            cbxDrink.Items.Clear();
            List<Drink> drinks = GetDrinks();
            foreach (Drink drink in drinks)
            {
                if (!cbxDrink.Items.Contains($"{drink.DrinkID}"))
                {
                    cbxDrink.Items.Add($"{drink.DrinkID} {drink.DrinkName}");
                }
            }
        }
    }
}
