using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Project1._4.Model;

namespace Project1._4.DAL
{
    public class OrderDao : BaseDao
    {
        // get all items from table
        public List<Order> GetAllOrders()
        {
            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return new List<Order>(); // remove this, this is just to prevent errors
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