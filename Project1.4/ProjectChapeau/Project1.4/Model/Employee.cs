using Microsoft.Graph.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Employee
    {
        public Employee(int employeeId, EmployeeType function, string username, string passwordHash, string name)
        {
            EmployeeId = employeeId;
            Function = function;
            Username = username;
            PasswordHash = passwordHash;
            Name = name;
        }

        public int EmployeeId { get; set; }
        public EmployeeType Function { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }

    }
}