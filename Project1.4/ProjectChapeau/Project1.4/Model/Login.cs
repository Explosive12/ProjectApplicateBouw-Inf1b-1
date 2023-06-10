using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Login
    {
        public int medewerkerId { get; set; }
        public string inlogNaam { get; set; }
        public string Hash { get; set; }
        public employeeType employeeType { get; set; }

    }
}