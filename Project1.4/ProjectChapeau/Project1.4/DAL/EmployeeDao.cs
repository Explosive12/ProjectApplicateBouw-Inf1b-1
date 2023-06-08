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
        const string connectionString = "Data Source=applicatiebouw.database.windows.net; Initial Catalog = databaseproject1.4; User=nrtjk14; Password=Kipsate14";

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            //Activiteit gegevens uit de database halen.
            string query = "SELECT naam, inlogNaam, functie FROM medewerker";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        public Employee GetEmployeeById(int id)
        {
            return null;
        }

        public void AddEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {

        }

        public void DeleteEmployee(Employee employee)
        {

        }

    }
}