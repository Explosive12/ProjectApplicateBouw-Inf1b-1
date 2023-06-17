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
using Microsoft.Graph.Models;

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
        public Table GetTableById(int tableId)
        {
            string query = "SELECT tafelId , reserveringId , status FROM tafel WHERE tafelId = @tableId";
            SqlParameter[] sqlParameters = { new SqlParameter("@tableId", tableId) };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Table> GetAllTables()
        {
            string query = "SELECT tafelId , reserveringId , status FROM tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTableStatus(TableStatus status, int tableId)
        {
            string query = "UPDATE tafel SET status = @status WHERE tafelId = @tableId";
            SqlParameter[] sqlParameters = { new SqlParameter("@status", (int)status), new SqlParameter("@tableId", tableId) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReserveTable(Reservation reservation , int tableId)
        {
            string query = "SELECT MAX(reserveringId) FROM tafel";
            SqlCommand cmd = new SqlCommand(query, OpenConnection());
            int highestReserveringsId = (int)cmd.ExecuteScalar();

            int reserveringId = highestReserveringsId + 1;

            query = "INSERT INTO reserMvering (reserveringId , naamKlant, opmerking, tijd, datum, telefoonNr) " +
                     "VALUES (@reserveringId , @naam , @opmerking , @tijd , @datum , @phoneNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
              new SqlParameter("@reserveringId" , reserveringId) ,
              new SqlParameter("@naam", reservation.naam),
              new SqlParameter("@opmerking", reservation.opmerking),
              new SqlParameter("@tijd", reservation.tijd) ,
              new SqlParameter("@datum", reservation.datum)  ,
              new SqlParameter("@phoneNumber", reservation.phoneNumber)  
            };
            ExecuteEditQuery(query, sqlParameters);

            query = "UPDATE tafel SET status = @status reserveringId = @reserveringId WHERE tafelId = @tableId";
            SqlParameter[] sqlParametersupdate = 
                {
                     new SqlParameter("@status" , (int)TableStatus.Gereseveerd) ,
                     new SqlParameter("@reserveringId", reservation.reservationId),
                     new SqlParameter("@tablId", tableId),
                };
            ExecuteEditQuery(query, sqlParametersupdate);
        }
    }
}