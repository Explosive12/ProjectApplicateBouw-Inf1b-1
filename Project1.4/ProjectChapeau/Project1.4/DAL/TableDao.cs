using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Project1._4.DAL
{
    public class TableDao : BaseDao
    {
        private List<Table> ReadTables(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
        public void GetTableById()
        {
            throw new NotImplementedException();
        }
        public List<Table> GetTables()
        {
            string query = "SELECT room_number, building, capacity, type FROM dbo.room";

            SqlParameter[] sqlParameters = Array.Empty<SqlParameter>();

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
          
        }

        public void UpdateTableStatus()
        {
            throw new System.NotImplementedException();
        }
        public void ReserveTable()
        {
            throw new System.NotImplementedException();
        }
    }
}