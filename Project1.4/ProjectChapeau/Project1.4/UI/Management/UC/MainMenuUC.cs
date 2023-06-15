﻿using Microsoft.Graph.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using Project1._4.Model;
using Project1._4.Service;
using Project1._4.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4
{
    public partial class MainMenuUC : UserControl
    {
        private ManagerView form;
        private string _currentEmployee;


        private EmployeeService _employeeService;
        private MenuProductService _menuproductService;

        private List<MenuProduct> _menuItems;
        private List<Employee> _employees;


        public MainMenuUC(ManagerView form)
        {
            _menuItems = new List<MenuProduct>();
            _employees = new List<Employee>();

            _currentEmployee = "Claire"; // TODO: get the current employee from the login screen

            InitializeComponent();
            labelUserName.Text = _currentEmployee;
            this.form = form;
        }

        private void NavigateToMenu(object sender, EventArgs e)
        {
            this.form.NavigateToMenu();

        }

        private void NavigateToEmployee(object sender, EventArgs e)
        {
            this.form.NavigateToEmployee();
        }

        // Loading all panels
        //private void HideAllPanels()
        //{
        //    ChangeEmployeePanel.Hide();
        //    ChangeMenuPanel.Hide();
        //    ChangeStockPanel.Hide();
        //    MenuPannel.Hide();
        //}

        //private void ViewEmployeesPanel()
        //{
        //    HideAllPanels();
        //    ChangeMenuPanel.Show();

        //    try
        //    {
        //        _employees = GetAllEmployees();
        //        DisplayAllEmployees();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show($"Something went wrong when loading the employees {e.Message}");
        //    }
        //}

        //private void ViewChangeMenuPanel()
        //{
        //    HideAllPanels();
        //    ChangeEmployeePanel.Show();
        //    try
        //    {
        //        _menuItems = GetAllMenuItems();
        //        //DisplayMenuItems();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show($"Something went wrong when loading the menu {e.Message}");
        //    }
        //}



        //private void ViewStockPanel()
        //{
        //    HideAllPanels();
        //    ChangeStockPanel.Show();

        //}

        //private void ViewMenuPanel()
        //{
        //    HideAllPanels();
        //    MenuPannel.Show();
        //}
        //// Loading TextBoxes and Comboboxes

        //// load the Employee info into the boxes
        //private void LoadEmployeeTextboxes()
        //{
        //    if (listViewEmployees.SelectedItems.Count != 1)
        //        return;
        //    ListViewItem selectedEmployeeItem = listViewEmployees.SelectedItems[0];
        //    Employee selectedEmployee = (Employee)selectedEmployeeItem.Tag;

        //    textBoxId.Text = selectedEmployee.EmployeeId.ToString();
        //    textBoxName.Text = selectedEmployee.Name;
        //    textBoxUserName.Text = selectedEmployee.Username;
        //    textBoxPassword.Text = selectedEmployee.LoginId.ToString();
        //    comboBoxEmployeeFunction.Text = selectedEmployee.Function.ToString();
        //}

        //// Loading and displaying items

        //private List<Employee> GetAllEmployees()
        //{
        //    EmployeeService service = new EmployeeService();
        //    List<Employee> employees = service.GetAllEmployees();
        //    return employees;
        //}

        //private void DisplayAllEmployees()
        //{
        //    // clear all the items in the listview and comboboxes
        //    listViewEmployees.Items.Clear();
        //    comboBoxEmployeeFunction.Items.Clear();

        //    // Add all items to the listview

        //    foreach (Employee employee in _employees)
        //    {
        //        ListViewItem employeeItem = new ListViewItem(employee.Name);
        //        employeeItem.Tag = employee;
        //        employeeItem.SubItems.Add(employee.Username);
        //        employeeItem.SubItems.Add(employee.Function.ToString());
        //    }
        //    // add the combobox Options

        //    comboBoxEmployeeFunction.Items.AddRange(Enum.GetNames(typeof(EmployeeType)));

        //}
        //private List<MenuProduct> GetAllMenuItems()
        //{

        //    MenuProductService service = new MenuProductService();
        //    List<MenuProduct> menuItems = service.GetAllMenuItems();
        //    return menuItems;
        //}

        //private void DisplayMenuItems(List<MenuProduct> menuItems)
        //{

        //}


        //// Employee code
        //private void AddEmployee()
        //{
        //    _employees = GetAllEmployees();
        //    DisplayAllEmployees();
        //    try
        //    {
        //        // Check if its valid
        //        if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "" || comboBoxEmployeeFunction.Text == "")
        //        {
        //            MessageBox.Show("Please fill in every box, thank youz <3");
        //            return;
        //        }

        //        // creating and adding a new Employee

        //        _employeeService.AddEmployee(SelectEmployee());
        //        MessageBox.Show($"{textBoxName.Text} has been added");
        //    }

        //    catch (Exception exp)
        //    {
        //        MessageBox.Show($"Something went wrong with adding {textBoxName.Text}");
        //    }

        //    finally
        //    {
        //        DisplayAllEmployees();
        //    }
        //}
        //private Employee SelectEmployee()
        //{

        //    //Employee newEmployee = new Employee(

        //    //    Name = textBoxName.Text,
        //    //    Username = textBoxUserName.Text,
        //    //    LoginId = int.Parse(textBoxPassword.Text),
        //    //    Function = (EmployeeType)comboBoxEmployeeFunction.SelectedItem
        //    //);
        //    //return newEmployee;
        //    return null;
        //}

        //private void UpdateEmployee()
        //{
        //    if (listViewEmployees.SelectedItems.Count == 0)
        //        return;
        //    else if (listViewEmployees.SelectedItems.Count != 1)
        //    {
        //        MessageBox.Show("Please select only 1 employee to update, thank youz <33");
        //        return;
        //    }
        //    if (listViewEmployees.SelectedItems.Count != 1)
        //    {

        //    }
        //    try
        //    {
        //        _employeeService.UpdateEmployee(SelectEmployee());
        //        MessageBox.Show($"The updating of {textBoxName.Text} went all wells");
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show($"Something went wrong with adding {textBoxName.Text}");
        //    }
        //    finally
        //    {
        //        DisplayAllEmployees();
        //    }

        //}

        //private void DeleteEmployee()
        //{
        //    if (listViewEmployees.SelectedItems.Count == 0)
        //        return;
        //    else if (listViewEmployees.SelectedItems.Count != 1)
        //    {
        //        MessageBox.Show("Please only 1 employee to delete, thank youz <33");
        //        return;
        //    }
        //    // have a yes no option, continue if yes is selected
        //    DialogResult EmployeeDeleteResult = MessageBox.Show($"Are you sure you want to delete this beautiful looking employee {textBoxName.Text}?", "Delete activity", MessageBoxButtons.YesNo);
        //    if (EmployeeDeleteResult == DialogResult.No)
        //        return;
        //    try
        //    {
        //        ListViewItem selectedEmployeeItem = listViewEmployees.SelectedItems[0];
        //        Employee selectedEmployee = (Employee)listViewEmployees.Tag;

        //        // delete the activity
        //        _employeeService.DeleteEmployee(selectedEmployee);

        //        MessageBox.Show($"Successfully deleted the activity {selectedEmployee.Name}!");

        //        // refresh the listview
        //        DisplayAllEmployees();


        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show($"Something went wrong with adding {textBoxName.Text}");
        //    }
        //}


    }
}