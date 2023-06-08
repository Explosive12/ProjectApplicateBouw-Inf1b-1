using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project1._4.DAL
{
    public class EmployeeDao : BaseDao
    {
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Order order = new Order(
            //        );
            //    orders.Add(product);
            //}
            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            return null;
        }

        public Employee GetEmployeeById(int id)
        {
            return null;
        }

        public void AddEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(Employee employee)
        {

        }

    }
}