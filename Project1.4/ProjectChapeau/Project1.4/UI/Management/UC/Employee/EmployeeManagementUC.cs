using Project1._4.Model;
using Project1._4.Service;

namespace Project1._4.UI.Management
{
    public partial class EmployeeManagementUC : UserControl
    {
        private readonly ManagerView _form;

        public EmployeeManagementUC(ManagerView form)
        {
            InitializeComponent();
            _form = form;
        }

        private void RefreshEmployeePanel()
        {
            try
            {
                panelEmployee.Controls.Clear();
                List<Employee> employees = GetAllEmployees();
                foreach (Employee employee in employees)
                {
                    panelEmployee.Controls.Add(new ItemButtonUC(employee));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
        }

        private List<Employee> GetAllEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> employees = service.GetAllEmployees();
            return employees;
        }

        private void EmployeeManagementOnLoad(object sender, EventArgs e)
        {
            RefreshEmployeePanel();
        }

        private void GoBackToMainMenuClick(object sender, EventArgs e)
        {
            _form.GoBackToMainMenu();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            _form.NavigateToAddOrAdjustEmployee("NEW EMPLOYEE", "ADD", null);
        }

        private void ButtonAdjustClick(object sender, EventArgs e)
        {
            Employee employee = GetSelectedEmployee();
            if (employee == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            _form.NavigateToAddOrAdjustEmployee("ADJUST EMPLOYEE", "ADJUST", employee);
        }

        private void ButtonRemoveClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = GetSelectedEmployee();
                if (employee == null)
                    return;

                EmployeeService service = new EmployeeService();
                service.DeleteEmployee(employee);

                RefreshEmployeePanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
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
