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
    public partial class AddAdjustEmployeeUC : UserControl
    {
        private ManagerView form;

        private AddItemUC name = new AddItemUC("Name");
        private AddItemUC username = new AddItemUC("Username");
        private AddAdjustItemComboBoxUC role = new AddAdjustItemComboBoxUC("Role", "EmployeeType");
        private AddItemUC password = new AddItemUC("Password", true);



        public AddAdjustEmployeeUC(ManagerView form, string typeOfPanelEmployeeText, string buttonText)
        {
            InitializeComponent();
            this.form = form;
            labelEmployeeChanges.Text = typeOfPanelEmployeeText;
            buttonAddEmployee.Text = buttonText;
            LoadControllers();
        }

        private void LoadControllers()
        {
            this.panelAddEmployee.Controls.Add(name);
            this.panelAddEmployee.Controls.Add(username);
            this.panelAddEmployee.Controls.Add(role);
            this.panelAddEmployee.Controls.Add(password);
        }

        private void NavigateToEmployee(object sender, EventArgs e)
        {
            form.NavigateToEmployee();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            // Add an employee to the database


            //EmployeeType employeeFunction = (EmployeeType)employeeType.ChosenOption;
            try
            {
                EmployeeService service = new EmployeeService();
                Employee employee = new Employee(0, (EmployeeType)role.ChosenOption, name.Value, username.Value, password.Value);
                service.AddEmployee(employee);

                form.NavigateToEmployee();
            }
            
            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong when adding {username.Value}{exp.Message}");
            }
        }
    }
}
