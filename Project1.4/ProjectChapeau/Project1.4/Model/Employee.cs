﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeType Function { get; set; }
        public int LoginId { get; set; }
        public string Username { get; set; }
        public int TableId { get; set; }
    }
}