using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Project1._4.DAL
{
    public class EmployeeDao : BaseDao
    {
        private EmployeeType GetEmployeeType(string type)
        {
            switch (type.ToLower())
            {
                case "manager":
                    return EmployeeType.Manager;
                case "chef":
                    return EmployeeType.Chef;
                case "waitress":
                    return EmployeeType.Waitress;
                case "bartender":
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
                EmployeeType function = GetEmployeeType(dr[1].ToString().ToLower());

                Employee employee = new Employee(
                    (int)dr[0],
                    function,
                    dr[2].ToString(),
                    (int)dr[3],
                    dr[4].ToString()

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
            string query = "INSERT INTO Medewerker (naam, inlogNaam, wachtwoord, functie) VALUES (@name, @username, @inlognaam @function)";
            SqlParameter[] parameters = new SqlParameter[3];
            {
                parameters[0] = new SqlParameter("@username", employee.Username);
                parameters[1] = new SqlParameter("@function", employee.Function);
                parameters[2] = new SqlParameter("@inlognaam", employee.LoginId);
                parameters[3] = new SqlParameter("@name", employee.Name);
            }


            ExecuteEditQuery(query, parameters);
        }

        public void UpdateEmployee(Employee employee)
        {
            // Talk to database to Update the employee
            string query = "Update Medewerker SET naam = @name, inlogNaam = @username, wachtwoord = @inlognaam, functie = @function WHERE medewerkerId = @id";
            SqlParameter[] parameters = new SqlParameter[4];
            {
            parameters[0] = new SqlParameter("@username", employee.Username);
            parameters[1] = new SqlParameter("@function", employee.Function);
            parameters[2] = new SqlParameter("@inlognaam", employee.LoginId);
            parameters[3] = new SqlParameter("@name", employee.Name);
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