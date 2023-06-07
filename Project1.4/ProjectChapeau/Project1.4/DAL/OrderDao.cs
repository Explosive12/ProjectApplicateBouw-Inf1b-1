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
            string query = "SELECT P.naam, BR.aantal, BR.opmerking, BR.[status] " +
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
            string query = "SELECT P.naam, BR.aantal, BR.opmerking, BR.[status] " +
                            "FROM bestelregel AS BR " +
                                "JOIN product AS P ON P.productId = BR.productId " +
                            $"WHERE bestellingId = {orderId} " +
                            "ORDER BY P.naam";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }


        public void InsertOrder(int tableId, int beginTime, int amount, string comment)
        {
            //Define the SQL query to insert a new order with the given parameters
            string query =  "INSERT INTO bestelling (tafelId, begintijd)" +
                            "VALUES(@tafelID, @begintijd)";

            //Create a new SQL connection and command with the above query
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@tafelID", tableId);
            command.Parameters.AddWithValue("@begintijd", beginTime);

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
            command.Parameters.AddWithValue("@aantal", amount);
            command.Parameters.AddWithValue("@opmerking", comment);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int seconnedTimeRowsAffected = command.ExecuteNonQuery();
            connection.Close();

            int totalRowsAffected = firstTimeRowsAffected + seconnedTimeRowsAffected;
        }
        public void RemoveOrder(int orderId)
        {
            //Define the SQL query to insert a new order with the given parameters
            string query =  "DELETE FROM bestelling " +
                            "WHERE bestellingId = @bestellingId";

            //Create a new SQL connection and command with the above query
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@bestellingId", orderId);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateOrder(int orderId, int tableId, DateTime beginTime, DateTime finishTime, int productId, int amount, string comment, OrderStatusEnum status)
        {
            //Define the SQL query to insert a new order with the given parameters
            string query =  "UPDATE bestelling " +
                                "SET tafelId = tableId, " +
                                "begintijd = beginTime, " +
                                "eindtijd = finishTime " +
                            "WHERE bestellingId = 1;";


            query = "UPDATE bestelregel" +
                    "SET productId = productId, " +
                        "aantal = amount, " +
                        "opmerking = comment, " +
                        "[status] = [status] " +
                    "WHERE bestellingId = 1;";

            //Create a new SQL connection and command with the above query
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@bestellingId", orderId);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
        }
    }
}