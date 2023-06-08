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
        public List<Login> GetAllUser()
        {
            string query = "SELECT medewerkerId , functie , inlogNaam , wachtwoord , naam FROM medewerker";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> logins = new List<Login>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Login login = new Login()
                {
                    medewerkerId = (int)dr["medewerkerId"],
                    employeeType = (employeeType)Enum.Parse(typeof(employeeType), dr["functie"].ToString()),
                    inlogNaam = (string)dr["inlogNaam"],
                    wachtwoord = (int)dr["wachtwoord"]
                };
                logins.Add(login);
            }
            return logins;
        }
        public void Authenticate()
        {
            string query = "SELECT medewerkerId , functie , inlogNaam , wachtwoord , naam FROM medewerker WHERE wachtwoord = @wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}