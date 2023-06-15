using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1._4.DAL
{
    public class TableDao : BaseDao
    {
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tafelId = (int)dr["tafelId"],
                    reseveringId = (int)dr["reseveringId"],
                    status = (TableStatus)dr["status"]
                };
                tables.Add(table);
            }
            return tables;
        }
        public void GetTableById()
        {
            string query = "SELECT tafelId , reservingId , status FROM tafel WHERE tafelId = @tafelId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Table> GetTables()
        {
            string query = "SELECT tafelId , reservingId , status FROM tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTableStatus()
        {
            string query = "UPDATE tafel set ... WHERE tafelId = {tafelId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReserveTable(int tafelId)
        {
            string query = "SELECT tafelId , reseveringId, status FROM tafel where tafelId = {tafelId}";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@tafelId" , tafelId) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}