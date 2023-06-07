using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Project1._4.DAL
{
    public class TableDao : BaseDao
    {
<<<<<<< Updated upstream
        private List<Table> ReadTables(DataTable dataTable)
        {
            throw new NotImplementedException();
=======
        public List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tafelId = (int)dr["tafelId"],
                    reseveringId = (int)dr["reseveringId"]
                    //status
                };
                tables.Add(table);
            }
            return tables;

>>>>>>> Stashed changes
        }
        public void GetTableById()
        {
            //
        }
        public List<Table> GetTables()
        {
<<<<<<< Updated upstream
            string query = "SELECT room_number, building, capacity, type FROM dbo.room";

            SqlParameter[] sqlParameters = Array.Empty<SqlParameter>();

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
          
=======
            string query = "SELECT tafelId , reservingId , status FROM tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
>>>>>>> Stashed changes
        }
        public void UpdateTableStatus()
        {
            string query = "UPDATE tafel set ...";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReserveTable(int tableId)
        {
            string query = "SELECT tafelId , reseveringId, status FROM tafel where tafelId = {tafelId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}