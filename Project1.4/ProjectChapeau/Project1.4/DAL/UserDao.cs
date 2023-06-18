using Microsoft.Graph.Models;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project1._4.DAL
{
    public class UserDoa : BaseDao
    {
        public Login ReadTables(DataTable dataTable)
        {
            Login login = new Login();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                login.MedewerkerId = (int)dr["medewerkerId"];
                login.employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["functie"].ToString());
                login.InlogNaam = (string)dr["inlogNaam"];
                login.Hash = (string)dr["wachtwoord"];
            }
            return login;
        }
        public Login LoginUser(string hash , string username)
        {
            string query = "SELECT medewerkerId , functie , inlogNaam , wachtwoord , naam FROM medewerker WHERE inlogNaam = @inlogNaam AND wachtwoord = @wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@inlogNaam", username), new SqlParameter("@wachtwoord" , hash)};
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}