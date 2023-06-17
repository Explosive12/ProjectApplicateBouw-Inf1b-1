using Project1._4.Model;
using Project1._4.Service;

namespace Project1._4.UI.Management.UC
{
    public partial class AddOrAdjustEmployeeUC : UserControl
    {
        private readonly ManagerView _form;
        private readonly Employee _employee;
        private readonly AddItemUC name = new AddItemUC("Name");
        private readonly AddItemUC username = new AddItemUC("Username");
        private readonly AddItemUC password = new AddItemUC("Password", true);
        private readonly AddOrAdjustItemComboBoxUC role = new AddOrAdjustItemComboBoxUC("Role", "EmployeeType");

        public AddOrAdjustEmployeeUC(ManagerView form, string panelText, string buttonText, Employee employee)
        {
            InitializeComponent();
            _form = form;
            _employee = employee;
            labelEmployeeChanges.Text = panelText;
            buttonAddAdjustEmployee.Text = buttonText;
            FillPanel(employee);
        }

        private void FillPanel(Employee employee)
        {
            if (employee != null)
            {
                name.Value = employee.Name;
                username.Value = employee.Username;
                role.ChosenOption = employee.Function.ToString();
                password.Value = employee.PasswordHash;
            }
            // Add ListviewHeaders to panel
            panelAddEmployee.Controls.Add(name);
            panelAddEmployee.Controls.Add(username);
            panelAddEmployee.Controls.Add(role);
            panelAddEmployee.Controls.Add(password);
        }

        private void NavigateToEmployeeClick(object sender, EventArgs e)
        {
            _form.NavigateToEmployee();
        }

        private void AddAdjustEmployeeClick(object sender, EventArgs e)
        {
            if (name.Value == "" || username.Value == "" || password.Value == "" || role.ChosenOption == null)
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            try
            {
                if (_employee != null)
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
            string hash = PasswordHasher.HashPassword(password.Value);
            Employee employee = new Employee(_employee.EmployeeId, employeeType, name.Value, hash, username.Value);
            service.AdjustEmployee(employee);

            _form.NavigateToEmployee();
        }
        private void AddEmployee()
        {
            // Add an employee to the database

            EmployeeService service = new EmployeeService();
            EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), role.ChosenOption);
            string hash = PasswordHasher.HashPassword(password.Value);
            Employee employee = new Employee(0, employeeType, name.Value, hash, username.Value);
            service.AddEmployee(employee);

            _form.NavigateToEmployee();
        }
    }
}
