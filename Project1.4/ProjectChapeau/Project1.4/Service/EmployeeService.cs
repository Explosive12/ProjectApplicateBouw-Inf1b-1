using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1._4.DAL;
using Project1._4.Model;

namespace Project1._4.Service
{
    public class EmployeeService
    {
        private EmployeeDao _employeeDb;

        public EmployeeService()
        {
            _employeeDb = new EmployeeDao();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = _employeeDb.GetAllEmployees();
            return employeeList;
        }
        
        public Employee GetEmployeeById(int employeeId)
        {
            Employee employee = _employeeDb.GetEmployeeById(employeeId);
            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDb.AddEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeDb.DeleteEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDb.UpdateEmployee(employee);
        }
    }
}