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
                    reseveringId = (int)dr["reserveringId"],
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
                table.reseveringId = (int)dr["reserveringId"];
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
        public List<Table> GetTables()
        {
            string query = "SELECT tafelId , reserveringId , status FROM tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTableStatus(Table table)
        {
            string query = "UPDATE tafel set status = @status WHERE tafelId = {tafelId}";
            SqlParameter[] sqlParameters = {new SqlParameter("@tafelId" , table.tafelId) , new SqlParameter("@status", table.status) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReserveTable(int tafelId)
        {
            string query = "SELECT tafelId , reserveringId, status FROM tafel where tafelId = {tafelId}";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@tafelId" , tafelId) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}