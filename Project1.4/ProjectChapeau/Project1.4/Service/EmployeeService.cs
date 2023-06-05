using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Service
{
    public class EmployeeService
    {
        private EmployeeDao employeeDb;

        public EmployeeService()
        {
            employeeDb = new EmployeeDao();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = employeeDb.GetAllOrders();
            return list;
        }

        public List<Employee> GetEmployeeByIdOrder(int orderId)
        {
            List<Employee> list = employeeDb.GetByIdOrder(orderId);
            return list;
        }

        public void InsertEmployee(Employee order)
        {
            employeeDb.InsertOrder(order);
        }
        public void RemoveEmployee(Employee order)
        {
            employeeDb.RemoveOrder(order);
        }
        public void UpdateEmployee(Employee order)
        {
            employeeDb.RemoveOrder(order);
        }

    }

    public class CopyOfEmployeeService
    {
        private EmployeeDao employeeDb;

        public CopyOfEmployeeService()
        {
            employeeDb = new EmployeeDao();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = employeeDb.GetAllOrders();
            return list;
        }

        public List<Employee> GetEmployeeByIdOrder(int orderId)
        {
            List<Employee> list = employeeDb.GetByIdOrder(orderId);
            return list;
        }

        public void InsertEmployee(Employee order)
        {
            employeeDb.InsertOrder(order);
        }
        public void RemoveEmployee(Employee order)
        {
            employeeDb.RemoveOrder(order);
        }
        public void UpdateEmployee(Employee order)
        {
            employeeDb.RemoveOrder(order);
        }

    }
}