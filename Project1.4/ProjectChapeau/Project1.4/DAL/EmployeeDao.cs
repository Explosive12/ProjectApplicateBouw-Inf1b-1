using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Project1._4.Model;

namespace Project1._4.DAL
{
    public class EmployeeDao : BaseDao
    {

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> orders = new List<Employee>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Order order = new Order(
            //        );
            //    orders.Add(product);
            //}
            return orders;
        }

        public void InsertEmployee(Employee order)
        {
            throw new NotImplementedException();

        }

        public void RemoveEmployee(Employee order)
        {
            throw new NotImplementedException();

        }

        public void UpdateEmployee(Employee order)
        {
            throw new NotImplementedException();

        }

        public List<Employee> GetEmployeeByIdOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();

        }

        public EmployeeDao()
        {
            throw new NotImplementedException();

        }
    }
}