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

            this.listBoxEmployee.Controls.Add(new UserEmployeeUC("Julian", EmployeeType.Bartender));
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
            foreach (Employee employee in employees)
            {
                this.listBoxEmployee.Controls.Add(new UserEmployeeUC(employee.Name, employee.Function));
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FillListView();
        }
    }
}
