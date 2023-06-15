using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.CodeDom.Compiler;

namespace Project1._4.DAL
{
    public class OrderItemDao : BaseDao
    {
        public List<OrderItem> GetAllOrderItems()
        {
            string query =  "SELECT id, bestellingId, productId, aantal, opmerking, status " +
                            "FROM bestelregel";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetOrderItemsByDinnerLunch()
        {
            string query =  "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                            "WHERE M.type='Lunch' " +
                            "OR M.type='Dinner'";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetOrderItemsByDrinks()
        {
            string query = "SELECT id, bestellingId, productId, aantal, opmerking, status " +
                            "FROM bestelregel";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetByOrderItemId(int orderItemId)
        {
            string query =  "SELECT id, bestellingId, productId, aantal, opmerking, status " +
                            "FROM bestelregel " +
                            "WHERE id = @orderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderItemId", orderItemId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem
                (
                    (int)dr["id"],
                    (int)dr["bestellingId"],
                    (int)dr["productId"],
                    (int)dr["aantal"],
                    (string)dr["opmerking"],
                    (OrderStatusEnum)dr["status"]
                );
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public void UpdateOrderItem(OrderItem orderItem) 
        {
            string query =  "UPDATE bestelregel " +
                            "SET id = @OrderItemId, bestellingId = @OrderId, productId = @ProductId, aantal = @Amount, opmerking = @Comment, status = @Status " +
                            "WHERE id = @OrderItemId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderItemId", orderItem.OrderItemId),
                new SqlParameter("@OrderId", orderItem.OrderId),
                new SqlParameter("@ProductId", orderItem.ProductId),
                new SqlParameter("@Amount", orderItem.Amount),
                new SqlParameter("@Comment", orderItem.Comment),
                new SqlParameter("@Status", orderItem.Status),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateOrderItemState(int clickeddata, int state)
        {
            string query =  "UPDATE bestelregel SET status = @Status " +
                            "WHERE id = @OrderItemId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderItemId", clickeddata),
                new SqlParameter("@Status", state)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderItem> GetByStatus(int orderItemId)
        {
            string query =  "SELECT id, bestellingId, productId, aantal, opmerking, status " +
                            "FROM bestelregel " +
                            "WHERE id = @orderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderItemId", orderItemId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}