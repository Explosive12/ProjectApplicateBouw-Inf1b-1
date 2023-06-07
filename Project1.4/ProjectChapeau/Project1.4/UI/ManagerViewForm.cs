using Microsoft.Graph.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4
{
    public partial class ManagerViewForm : UserControl
    {
        private EmployeeService _employeeService;
        private MenuProductService _menuproductService;

        private List<MenuProduct> _menuItems;
        private List<Employee> _employees;


        public ManagerViewForm()
        {
            _menuItems = new List<MenuProduct>();
            _employees = new List<Employee>();
            InitializeComponent();
        }

        // Loading all panels
        private void HideAllPanels()
        {
            ChangeEmployeePanel.Hide();
            ChangeMenuPanel.Hide();
            ChangeStockPanel.Hide();
            MenuPannel.Hide();
        }

        private void ViewEmployeesPanel()
        {
            HideAllPanels();
            ChangeMenuPanel.Show();

            try
            {
                _employees = GetAllEmployees();
                DisplayAllEmployees();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong when loading the employees {e.Message}");
            }
        }

        private void ViewChangeMenuPanel()
        {
            HideAllPanels();
            ChangeEmployeePanel.Show();
            try
            {
                _menuItems = GetAllMenuItems();
                //DisplayMenuItems();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong when loading the menu {e.Message}");
            }
        }



        private void ViewStockPanel()
        {
            HideAllPanels();
            ChangeStockPanel.Show();

        }

        private void ViewMenuPanel()
        {
            HideAllPanels();
            MenuPannel.Show();
        }
        // Loading TextBoxes and Comboboxes

        // load the Employee info into the boxes
        private void LoadEmployeeTextboxes()
        {
            if (listViewEmployees.SelectedItems.Count != 0)
                return;
            ListViewItem selectedEmployeeItem = listViewEmployees.SelectedItems[0];
            Employee selectedEmployee = (Employee)selectedEmployeeItem.Tag;

            textBoxId.Text = selectedEmployee.EmployeeId.ToString();
            textBoxName.Text = selectedEmployee.Name;
            textBoxUserName.Text = selectedEmployee.Username;
            textBoxPassword.Text = selectedEmployee.LoginId.ToString();
            comboBoxEmployeeFunction.Text = selectedEmployee.Function.ToString();
        }

        // Loading and displaying items

        private List<Employee> GetAllEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> employees = service.GetAllEmployees();
            return employees;
        }

        private void DisplayAllEmployees()
        {
            // clear all the items in the listview and comboboxes
            listViewEmployees.Items.Clear();
            comboBoxEmployeeFunction.Items.Clear();

            // Add all items to the listview

            foreach (Employee employee in _employees)
            {
                ListViewItem employeeItem = new ListViewItem(employee.Name);
                employeeItem.Tag = employee;
                employeeItem.SubItems.Add(employee.Username);
                employeeItem.SubItems.Add(employee.Function.ToString());
            }
            // add the combobox Options

            comboBoxEmployeeFunction.Items.AddRange(Enum.GetNames(typeof(EmployeeType)));

        }
        private List<MenuProduct> GetAllMenuItems()
        {

            MenuProductService service = new MenuProductService();
            List<MenuProduct> menuItems = service.GetAllMenuItems();
            return menuItems;
        }

        private void DisplayMenuItems(List<MenuProduct> menuItems)
        {

        }


        // Employee code
        private void AddEmployee()
        {
            try
            {
                // Check if its valid
                if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "" || comboBoxEmployeeFunction.Text == "")
                {
                    MessageBox.Show("Please fill in every box, thank youz <3");
                    return;
                }

                // creating and adding a new Employee

                _employeeService.AddEmployee(SelectEmployee());
                MessageBox.Show($"{textBoxName.Text} has been added");
            }

            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong with adding {textBoxName.Text}");
            }

            finally
            {
                DisplayAllEmployees();
            }
        }
        private Employee SelectEmployee()
        {
            Employee newEmployee = new Employee()
            {
                Name = textBoxName.Text,
                Username = textBoxUserName.Text,
                LoginId = int.Parse(textBoxPassword.Text),
                Function = (EmployeeType)comboBoxEmployeeFunction.SelectedItem
            };
            return newEmployee;
        }

        private void UpdateEmployee()
        {
            if (listViewEmployees.SelectedItems.Count != 0)
            {
                MessageBox.Show("Please only 1 activity to update, thank youz <33");
                return;
            }
            try
            {
                _employeeService.UpdateEmployee(SelectEmployee());
                MessageBox.Show($"The editing of {textBoxName.Text} went all wells");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong with adding {textBoxName.Text}");
            }
            finally
            {
                DisplayAllEmployees();
            }

        }

        private void DeleteEmployee()
        {
            if (listViewEmployees.SelectedItems.Count != 0)
            {
                MessageBox.Show("Please only 1 activity to delete, thank youz <33");
                return;

            }
        }

        // Change Menu Code

        private void AddMenuItem(Menu menuItem)
        {

        }

        public void UpdateMenuItem(Menu menuItem)
        {

        }

        public void DeleteMenuItem(Menu menuItem)
        {

        }

        // Change Stock Code

        public void UpdateStock(int amount)
        {

        }

        public void RevertStock(int amount)
        {

        }





        //
        // EVENTS
        //

        // Loading Event

        private void ManagerViewForm_Load(object sender, EventArgs e)
        {
            MenuPannel.Show();
        }


        // MenuPanel Buttons

        private void GoToChangeEmployeePanel_Click(object sender, EventArgs e)
        {
            ViewEmployeesPanel();
        }

        private void GoToChangeMenuPanel_Click(object sender, EventArgs e)
        {
            ViewChangeMenuPanel();
        }

        private void GoToChangeStockPanel_Click(object sender, EventArgs e)
        {
            ViewStockPanel();
        }

        // Employee Events
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void buttonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployeeTextboxes();
        }
    }
}
