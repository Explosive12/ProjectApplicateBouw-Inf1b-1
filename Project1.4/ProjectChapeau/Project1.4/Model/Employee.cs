using Microsoft.Graph.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Employee
    {
        public Employee(int employeeId, EmployeeType function, string username, int loginId, string name)
        {
            Name = name;
            EmployeeId = employeeId;
            Function = function;
            LoginId = loginId;
            Username = username;
            

        }

        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeType Function { get; set; }
        public int LoginId { get; set; }
        public string Username { get; set; }
    }
}