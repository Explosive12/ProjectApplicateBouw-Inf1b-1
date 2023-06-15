using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Project1._4.DAL
{
    public class EmployeeDao : BaseDao
    {
        private EmployeeType GetEmployeeType(int type)
        {
            switch (type)
            {
                case 1:
                    return EmployeeType.Manager;
                case 2:
                    return EmployeeType.Chef;
                case 3:
                    return EmployeeType.Waitress;
                case 4:
                    return EmployeeType.Bartender;
                default:
                    return EmployeeType.Waitress;
            }
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();


            foreach (DataRow dr in dataTable.Rows)
            {
                EmployeeType function = GetEmployeeType((int)dr[1]);

                Employee employee = new Employee(
                    (int)dr[0], // ID
                    function, // EmployeeType
                    dr[2].ToString(), // Username
                    dr[3].ToString(), // Password
                    dr[4].ToString() // Name

                );
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            //Employee gegevens uit de database halen.
            string query = "SELECT medewerkerId ,functie, inlogNaam, wachtwoord, naam FROM Medewerker";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public Employee GetEmployeeById(int id)
        {
            //Employee gegevens uit de database halen van een Persoon.
            string query = "SELECT medewerkerId ,functie, inlogNaam, wachtwoord, naam FROM Medewerker WHERE medewerkerId = @id";
            SqlParameter parameter = new SqlParameter("@id", id);
            return ReadTables(ExecuteSelectQuery(query, parameter))[0];
        }

        public void AddEmployee(Employee employee)
        {
            // Talk to database to add the employee
            string query = "INSERT INTO Medewerker (naam, inlogNaam, wachtwoord, functie) VALUES (@name, @username, @inlognaam, @function)";
            SqlParameter[] parameters = new SqlParameter[4];
            {
                parameters[0] = new SqlParameter("@username", employee.Username);
                parameters[1] = new SqlParameter("@function", employee.Function);
                parameters[2] = new SqlParameter("@inlognaam", employee.Password);
                parameters[3] = new SqlParameter("@name", employee.Name);
            }


            ExecuteEditQuery(query, parameters);
        }

        public void AdjustEmployee(Employee employee)
        {
            // Talk to database to Update the employee
            string query = "Update Medewerker SET naam = @name, inlogNaam = @username, wachtwoord = @inlognaam, functie = @function WHERE medewerkerId = @id";
            SqlParameter[] parameters = new SqlParameter[5];
            {
                parameters[0] = new SqlParameter("@id", employee.EmployeeId);
                parameters[1] = new SqlParameter("@username", employee.Username);
                parameters[2] = new SqlParameter("@function", employee.Function);
                parameters[3] = new SqlParameter("@inlognaam", employee.Password);
                parameters[4] = new SqlParameter("@name", employee.Name);
            };
            ExecuteEditQuery(query, parameters);
        }

        public void DeleteEmployee(Employee employee)
        {
            string query = "DELETE FROM Medewerker WHERE medewerkerId = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", employee.EmployeeId) };
            ExecuteEditQuery(query, parameters);
        }
    }
}