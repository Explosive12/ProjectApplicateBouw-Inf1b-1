using Project1._4.DAL;
using Project1._4.Model;

namespace Project1._4.Service
{
    public class EmployeeService
    {
        private EmployeeDao _employeeDao;

        public EmployeeService()
        {
            _employeeDao = new EmployeeDao();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = _employeeDao.GetAllEmployees();
            return employeeList;
        }
        
        public void AddEmployee(Employee employee)
        {
            _employeeDao.AddEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeDao.DeleteEmployee(employee);
        }

        public void AdjustEmployee(Employee employee)
        {
            _employeeDao.AdjustEmployee(employee);
        }
    }
}