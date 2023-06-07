using Microsoft.Graph.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
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

namespace Project1._4
{
    public partial class ManagerViewForm : UserControl
    {
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

        // Loading and displaying items

        private List<Employee> GetAllEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> employees = service.GetAllEmployees();
            return employees;
        }

        private void DisplayAllEmployees()
        {
            // clear all the items in the listview
            listViewEmployees.Items.Clear();

            // Add all items to the listview

            foreach (Employee employee in _employees)
            {
                ListViewItem employeeItem = new ListViewItem(employee.Name);
                employeeItem.Tag = employee;
                employeeItem.SubItems.Add(employee.Username);
                employeeItem.SubItems.Add(employee.Function.ToString());
            }

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

        }

        private void UpdateEmployee()
        {

        }

        private void DeleteEmployee()
        {

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
    }
}
