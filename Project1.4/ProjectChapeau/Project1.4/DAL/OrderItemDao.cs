using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project1._4.DAL
{
    public class OrderItemDao
    {
        // get all items from table
        public List<OrderItem> GetAllOrderItems()
        {
            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return new List<OrderItem>(); // remove this, this is just to prevent errors
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    OrderItem orderItem = new OrderItem(
            //        );
            //    orderItems.Add(orderItem);
            //}
            return orderItems;
        }

        public List<OrderItem> GetByIdOrderItem(int orderItemId)
        {
            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTablesSupervisor(ExecuteSelectQuery(query, sqlParameters));
            return new List<OrderItem>(); // !!!remove this, this is just to prevent errors!!!
        }

        public void InsertOrderItem(OrderItem orderItem) { }
        public void RemoveOrderItem(OrderItem orderItem) { }
        public void UpdateOrderItem(OrderItem orderItem) { }
    }
}