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
        public ManagerViewForm()
        {
            InitializeComponent();
        }

        // Loading and displaying items

        public List<Menu> LoadMenuItems()
        {
            MenuService service = new MenuService();
            List<Menu> menuItems = service.GetAllMenuItems();
            return menuItems;
        }

        public List<Employee> LoadEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> employees = service.GetAllEmployees();
            return employees;
        }

        // Employee Part
        public void AddEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(Employee employee)
        {

        }

        // Menu Part

        public void AddMenuItem(Menu menuItem)
        {

        }

        public void UpdateMenuItem(Menu menuItem)
        {

        }

        public void DeleteMenuItem(Menu menuItem)
        {

        }

        // Stock part

        public void UpdateStock(int amount)
        {

        }

        public void RevertStock(int amount)
        {

        }
    }
}
