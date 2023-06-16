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

namespace Project1._4.UI.Management
{
    public partial class EmployeeManagementUC : UserControl
    {
        private ManagerView form;

        public EmployeeManagementUC(ManagerView form)
        {
            InitializeComponent();
            this.form = form;

        }

        private List<Employee> GetAllEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> employees = service.GetAllEmployees();
            return employees;
        }

        private void RefreshEmployeePanel()
        {
            panelEmployee.Controls.Clear();
            List<Employee> employees = GetAllEmployees();
            foreach (Employee employee in employees)
            {
                panelEmployee.Controls.Add(new ItemButtonUC(employee));
            }
        }

        private void EmployeeManagementOnLoad(object sender, EventArgs e)
        {
            RefreshEmployeePanel();
        }

        private void GoBackToMainMenu(object sender, EventArgs e)
        {
            form.GoBackToMainMenu();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            NavigateToAddOrAdjustEmployee("NEW EMPLOYEE", "ADD", null);
        }

        private void buttonAdjust_Click(object sender, EventArgs e)
        {
            Employee employee = GetSelectedEmployee();
            if (employee == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            NavigateToAddOrAdjustEmployee("ADJUST EMPLOYEE", "ADJUST", employee);
        }

        private void NavigateToAddOrAdjustEmployee(string panelname, string buttonName, Employee employee)
        {
            form.NavigateToAddOrAdjustEmployee(panelname, buttonName, employee);
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            Employee employee = GetSelectedEmployee();
            if (employee == null)
                return;
            
            EmployeeService service = new EmployeeService();
            service.DeleteEmployee(employee);

            RefreshEmployeePanel();
        }
        private Employee GetSelectedEmployee()
        {
            foreach (ItemButtonUC userEmployeeUC in panelEmployee.Controls.OfType<ItemButtonUC>())
            {
                if (userEmployeeUC.IsSelected)
                    return userEmployeeUC.Employee;
            }
            return null!;
        }
    }
}
