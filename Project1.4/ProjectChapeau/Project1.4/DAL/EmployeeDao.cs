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
            return (EmployeeType)type;
        }
        private List<Employee> ReadEmployees(DataTable dataTable)
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
            return ReadEmployees(ExecuteSelectQuery(query));
        }

        public void AddEmployee(Employee employee)
        {
            // Talk to database to add the employee
            string query = "INSERT INTO Medewerker (functie, inlogNaam, wachtwoord, naam) VALUES (@function, @username,  @password, @name)";
            SqlParameter[] parameters = new SqlParameter[4];
            {
                parameters[0] = new SqlParameter("@function", employee.Function);
                parameters[1] = new SqlParameter("@username", employee.Username);
                parameters[2] = new SqlParameter("@password", employee.Password);
                parameters[3] = new SqlParameter("@name", employee.Name);

            }
            

            ExecuteEditQuery(query, parameters);
        }

        public void AdjustEmployee(Employee employee)
        {
            // Talk to database to Update the employee
            string query = "Update Medewerker SET naam = @name, inlogNaam = @username, wachtwoord = @password, functie = @function WHERE medewerkerId = @id";
            SqlParameter[] parameters = new SqlParameter[5];
            {
                parameters[0] = new SqlParameter("@id", employee.EmployeeId);
                parameters[1] = new SqlParameter("@username", employee.Username);
                parameters[2] = new SqlParameter("@function", employee.Function);
                parameters[3] = new SqlParameter("@password", employee.Password);
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