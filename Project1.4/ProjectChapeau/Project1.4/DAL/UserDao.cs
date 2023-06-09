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
        private Login ReadTables(DataTable dataTable)
        {
            Login login = new Login();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                login.medewerkerId = (int)dr["medewerkerId"];
                login.employeeType = (employeeType)Enum.Parse(typeof(employeeType), dr["functie"].ToString());
                login.inlogNaam = (string)dr["inlogNaam"];
                login.wachtwoord = (int)dr["wachtwoord"];
            }
            return login;
            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Login login = new Login()
            //    {
            //        medewerkerId = (int)dr["medewerkerId"],
            //        employeeType = (employeeType)Enum.Parse(typeof(employeeType), dr["functie"].ToString()),
            //        inlogNaam = (string)dr["inlogNaam"],
            //        wachtwoord = (int)dr["wachtwoord"]
            //    };
            //    logins.Add(login);
            //}
            //return logins;
        }
        public Login LoginUser(string hash)
        {
            string query = "SELECT medewerkerId , functie , inlogNaam , wachtwoord , naam FROM medewerker WHERE wachtwoord = @wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}