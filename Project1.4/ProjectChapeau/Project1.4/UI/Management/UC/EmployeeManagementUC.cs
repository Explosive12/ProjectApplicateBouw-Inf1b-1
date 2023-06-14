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
        private readonly ManagerView form;

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

        private void FillListView()
        {
            List<Employee> employees = GetAllEmployees();
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                this.panelEmployee.Controls.Add(new UserEmployeeUC(employee.Name+i, employee.Function));
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FillListView();
        }

        private void GoBackToMainMenu(object sender, EventArgs e)
        {

            form.GoBackToMainMenu();
        }

        private void NavigateToAddEmployee(object sender, EventArgs e)
        {
            form.NavigateToAddEmployee();
        }
    }
}
