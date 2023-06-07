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

namespace Project1._4.DAL
{
    public class OrderDao : BaseDao
    {
        //connection string for the database
        const string connectionString = "Data Source=someren2023db.database.windows.net; Initial Catalog=someren_db; User=somerendb; Password=kaleharrie3895!";
        // get all items from table
        public List<Order> GetAllOrders()
        {
            //Activiteit gegevens uit de database halen.

            //TODO querry aanpassen voor de juiste data
            string query = "SELECT activiteitID, activiteitNaam, startDatum, eindDatum " +
                            "FROM Activiteit " +
                            "ORDER BY activiteitID";
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
            ///TODO eddit querry to mach names from project 1.4
            //Define the SQL query to insert a new order with the given parameters
            string query = "INSERT INTO [Activiteit_deelnemers] (activiteitID, studentID) " +
                            "VALUES (@activiteitID, @studentID)";

            //Create a new SQL connection and command with the above query
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            //Add parameters to the command to set the values of the activity ID, student ID
            command.Parameters.AddWithValue("@activiteitID", Activity);
            command.Parameters.AddWithValue("@studentID", StudentID);

            //Open the database connection, execute the query, and close the connection
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTablesSupervisor(ExecuteSelectQuery(query, sqlParameters));
            return new List<Order>(); // remove this, this is just to prevent errors
        }

        public void InsertOrder(Order order) { }
        public void RemoveOrder(Order order) { }
        public void UpdateOrder(Order order) { }
    }
}