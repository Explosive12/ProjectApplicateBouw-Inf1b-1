using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using Project1._4.Model;
using Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using System.Windows.Forms;

namespace Project1._4.DAL
{
    public class OrderDao : BaseDao
    {
        //connection string for the database
        const string connectionString = "Data Source=applicatiebouw.database.windows.net; Initial Catalog = databaseproject1.4; User=nrtjk14; Password=Kipsate14";

        // get all items from table
        public List<Order> GetAllOrders()
        {
            //Activiteit gegevens uit de database halen.
            string query =  "SELECT P.naam, BR.aantal, BR.opmerking " +
                            "FROM bestelregel AS BR " +
                                "JOIN product AS P ON P.productId = BR.productId";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Order order = new Order(
            //        );
            //    orders.Add(product);
            //}
            return orders;
        }

        public List<Order> GetByIdOrder(int orderId)
        {
            //Activiteit gegevens uit de database halen.

            //TODO change query to mach the objective of the method
            string query =  "SELECT P.naam, BR.aantal, BR.opmerking " +
                            "FROM bestelregel AS BR " +
                                "JOIN product AS P ON P.productId = BR.productId " +
                            $"WHERE bestellingId = {orderId} " +
                            "ORDER BY P.naam";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }


        public void InsertOrder(int tafelId, int beginTijd, int aantal, string opmerking)
        {
            //Define the SQL query to insert a new order with the given parameters
            string query =  "INSERT INTO bestelling (tafelId, begintijd)" +
                            "VALUES(@tafelID, @begintijd)";

            //Create a new SQL connection and command with the above query
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@tafelID", tafelId);
            command.Parameters.AddWithValue("@begintijd", beginTijd);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int firstTimeRowsAffected = command.ExecuteNonQuery();
            connection.Close();





            //Define the SQL query to insert a new order with the given parameters
            query = "INSERT INTO bestelregel (aantal, opmerking) " +
                    "VALUES (@aantal, @opmerking)";

            //Create a new SQL connection and command with the above query
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@aantal", aantal);
            command.Parameters.AddWithValue("@opmerking", opmerking);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int seconnedTimeRowsAffected = command.ExecuteNonQuery();
            connection.Close();

            int totalRowsAffected = firstTimeRowsAffected + seconnedTimeRowsAffected;
        }
        public void RemoveOrder(Order order) { }
        public void UpdateOrder(Order order) { }
    }
}