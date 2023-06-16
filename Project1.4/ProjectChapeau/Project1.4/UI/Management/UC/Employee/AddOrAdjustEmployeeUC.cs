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
    public partial class AddOrAdjustEmployeeUC : UserControl
    {
        private readonly ManagerView _form;
        private readonly Employee _employee;
        private AddItemUC name = new AddItemUC("Name");
        private AddItemUC username = new AddItemUC("Username");
        private AddOrAdjustItemComboBoxUC role = new AddOrAdjustItemComboBoxUC("Role", "EmployeeType");
        private AddItemUC password = new AddItemUC("Password", true);



        public AddOrAdjustEmployeeUC(ManagerView form, string typeOfPanelEmployeeText, string buttonText, Employee employee)
        {
            InitializeComponent();
            _form = form;
            _employee = employee;
            labelEmployeeChanges.Text = typeOfPanelEmployeeText;
            buttonAddAdjustEmployee.Text = buttonText;
            LoadControllers(employee);
        }

        private void LoadControllers(Employee employee)
        {
            if (employee != null)
            {
                name.Value = employee.Name;
                username.Value = employee.Username;
                role.ChosenOption = employee.Function.ToString();
                password.Value = employee.Password;
            }
            this.panelAddEmployee.Controls.Add(name);
            this.panelAddEmployee.Controls.Add(username);
            this.panelAddEmployee.Controls.Add(role);
            this.panelAddEmployee.Controls.Add(password);
        }

        private void NavigateToEmployee(object sender, EventArgs e)
        {
            _form.NavigateToEmployee();
        }

        private void AddAdjustEmployee_Click(object sender, EventArgs e)
        {
            if (name.Value == "" || username.Value == "" || password.Value == "" || role.ChosenOption == null)
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            try
            {
                if (buttonAddAdjustEmployee.Text == "ADJUST")
                    AdjustEmployee();
                else
                    AddEmployee();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Something went wrong while adding or adjusting {username.Value}{exp.Message}");
            }
        }

        private void AdjustEmployee()
        {
            // Adjust an employee in the database

            EmployeeService service = new EmployeeService();
            EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), role.ChosenOption);
            Employee employee = new Employee(_employee.EmployeeId, employeeType, name.Value, password.Value, username.Value);
            service.AdjustEmployee(employee);

            _form.NavigateToEmployee();
        }
        private void AddEmployee()
        {
            // Add an employee to the database

            EmployeeService service = new EmployeeService();
            EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), role.ChosenOption);
            Employee employee = new Employee(0, employeeType, name.Value, password.Value, username.Value);
            service.AddEmployee(employee);

            _form.NavigateToEmployee();
        }
    }
}
