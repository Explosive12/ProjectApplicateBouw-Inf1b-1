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

namespace Project1._4.UI.Management.UC
{
    public partial class AddEmployeeUC : UserControl
    {
        private ManagerView form;

        AddItemUC addNameUC = new AddItemUC("Name");
        AddItemUC addUserNameUC = new AddItemUC("Username");
        AddItemUC addRole = new AddItemUC("Role");
        AddItemUC addPassword = new AddItemUC("Password");
        public AddEmployeeUC(ManagerView form)
        {
            InitializeComponent();
            this.form = form;




            this.panelAddEmployee.Controls.Add(addNameUC);
            this.panelAddEmployee.Controls.Add(addUserNameUC);
            this.panelAddEmployee.Controls.Add(addRole);
            this.panelAddEmployee.Controls.Add(addPassword);
        }

        private void GoBackToEmployee(object sender, EventArgs e)
        {
            form.NavigateToEmployee();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            // Add an employee to the database

            try
            {
                //Employee employee = new Employee(addNameUC.Text, addUserNameUC.Text, addRole.Text, addPassword.Text);
                //EmployeeService service = new EmployeeService();
                //service.AddEmployee(employee);

                form.NavigateToEmployee();

            }

            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong with adding {addUserNameUC.Text}");
            }
        }
    }
}
