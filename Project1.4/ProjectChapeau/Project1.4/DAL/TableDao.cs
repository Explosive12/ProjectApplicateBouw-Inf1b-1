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
                    reseveringId = Convert.IsDBNull(dr["reserveringId"]) ? 0 : (int)dr["reserveringId"],
                    status = (TableStatus)dr["status"]
                };
                tables.Add(table);
            }
            return tables;
        }
        private Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();

            foreach (DataRow dr in dataTable.Rows)
            {
                table.tafelId = (int)dr["tafelId"];
                table.reseveringId = Convert.IsDBNull(dr["reserveringId"]) ? 0 : (int)dr["reserveringId"];
                table.status = (TableStatus)dr["status"];
            }
            return table;
        }
        public Table GetTableById(int tableid)
        {
            string query = "SELECT tafelId , reserveringId , status FROM tafel";
            SqlParameter[] sqlParameters = { new SqlParameter("@tableId" , tableid)};
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Table> GetAllTables()
        {
            string query = "SELECT tafelId , reserveringId , status FROM tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTableStatus(TableStatus status ,int tableId)
        {
            string query = "UPDATE tafel SET status = @status WHERE tafelId = @tableId";
            SqlParameter[] sqlParameters = {new SqlParameter("@status" , (int)status) , new SqlParameter("@tableId", tableId) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReserveTable(TableStatus status, int tableId)
        {
            string query = "SELECT max(reserveringId) FROM tafel";
            SqlCommand cmd = new(query, OpenConnection());
            int highestReseveringsId = (int)cmd.ExecuteScalar();

            int reserveringId = highestReseveringsId + 1;

            query = "UPDATE tafel SET status = @status , reserveringId = @reserveringId WHERE tafelId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@status" , (int)status) , new SqlParameter("@reserveringId", reserveringId), new SqlParameter("@tableId", tableId) };
            ExecuteEditQuery(query, sqlParameters);


        }
    }
}