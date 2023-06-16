using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using Microsoft.Graph.Models;
using System.Web;

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
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE (M.type='Lunch' OR M.type='Dinner') " +
                                "AND B.status !='2' " +
                            "ORDER BY begintijd";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetOrderItemsByDrinks()
        {
            string query =  "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE M.type='Drinks' " +
                                "AND B.status !='2' " +
                            "ORDER BY begintijd";
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

        public void UpdateOrderItemState(int clickeddata, int state)
        {
            string query = string.Empty;
            SqlParameter[] sqlParameters = null;
            DateTime finishTime = DateTime.Now;

            //if (served)
            //{
            //    query = "UPDATE bestelling SET eindtijd = @Eindtijd " +
            //            "WHERE bestellingId = @BestellingID";
            //    sqlParameters = new SqlParameter[]
            //    {
            //        new SqlParameter("@Eindtijd", finishTime),
            //        new SqlParameter("@BestellingId", clickeddata),
            //    };
            //    ExecuteEditQuery(query, sqlParameters);
            //}


            query = "UPDATE bestelregel SET status = @Status " +
                        "WHERE id = @OrderItemId";
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderItemId", clickeddata),
                new SqlParameter("@Status", state),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderItem> GetByStatusKitchen(int orderItemId)
        {
            string query =  "SELECT id, bestellingId, productId, aantal, opmerking, status " +
                            "FROM bestelregel " +
                            "WHERE id = @orderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderItemId", orderItemId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetByStatusBar(int intValue)
        {
            string query = "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE [status] = @IntValue " +
                                "AND M.type='Drinks' " +
                            "ORDER BY begintijd";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@IntValue", intValue);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}