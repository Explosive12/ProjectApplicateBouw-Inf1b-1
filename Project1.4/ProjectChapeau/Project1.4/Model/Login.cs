using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Login
    {
        public int MedewerkerId { get; set; }
        public string InlogNaam { get; set; }
        public string Hash { get; set; }
        public EmployeeType employeeType { get; set; }
    }
}