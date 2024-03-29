﻿using Project1._4.Model;
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
            string query = "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status, bestelling.begintijd, bestelling.tafelId " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE (M.type='Lunch' OR M.type='Dinner') " +
                                "AND B.status !='2' " +
                            "ORDER BY begintijd";
            return ReadTablesDateTafel(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetOrderItemsByDrinks()
        {
            string query = "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status, bestelling.begintijd, bestelling.tafelId " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE M.type='Drinks' " +
                                "AND B.status !='2' " +
                            "ORDER BY begintijd";
            return ReadTablesDateTafel(ExecuteSelectQuery(query));
        }
        public List<OrderItem> GetByOrderItemId(int orderItemId)
        {
            string query =  "SELECT bestelregel.id, bestelregel.bestellingId, productId, aantal, opmerking, status, begintijd, bestelling.tafelId " +
                            "FROM bestelregel " +
                                "JOIN bestelling ON bestelregel.bestellingId = bestelling.bestellingId " +
                            "WHERE bestelregel.id = @orderItemId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderItemId", orderItemId);
            return ReadTablesDateTafel(ExecuteSelectQuery(query, sqlParameters));
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

        private List<OrderItem> ReadTablesDateTafel(DataTable dataTable)
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
                    (OrderStatusEnum)dr["status"],
                    (DateTime)dr["begintijd"],
                    (int)dr["tafelId"]
                );
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        private int GetNextAvailableId()
        {
            string query = "SELECT COUNT(*) FROM bestelregel";
            int count = ReadCountTable(ExecuteSelectQuery(query)) + 1;
            return count;
        }

        private int ReadCountTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            int count = (int)dr[0];
            return count;
        }

        public void InsertOrderItems(List<OrderItem> orderItems)
        {
            string query = "INSERT INTO bestelregel (id, bestellingId, productId, aantal, opmerking, status) " +
                           "VALUES (@OrderItemId, @OrderId, @ProductId, @Amount, @Comment, @Status)";
            foreach (OrderItem orderItem in orderItems)
            {
                orderItem.OrderItemId = GetNextAvailableId();
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
        }

        public void UpdateOrderItemState(int clickeddata, int state)
        {
            string query = "UPDATE bestelregel SET status = @Status " +
                            "WHERE id = @OrderItemId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderItemId", clickeddata),
                new SqlParameter("@Status", state),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderItem> GetByStatusKitchen(int orderItemId)
        {
           string query = "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status, bestelling.begintijd, bestelling.tafelId  " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE (M.type='Lunch' OR M.type='Dinner') " +
                                "AND [status] = @IntValue " +
                            "ORDER BY begintijd";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@IntValue", orderItemId);
            return ReadTablesDateTafel(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetByStatusBar(int intValue)
        {
            string query = "SELECT B.id, B.bestellingId, B.productId, B.aantal, B.opmerking, B.status, bestelling.begintijd, bestelling.tafelId " +
                            "FROM bestelregel as B " +
                                "JOIN product as P ON P.productId = B.productId " +
                                "JOIN menu as M ON P.productId = M.productId " +
                                "JOIN bestelling ON B.bestellingId = bestelling.bestellingId " +
                            "WHERE [status] = @IntValue " +
                                "AND M.type='Drinks' " +
                            "ORDER BY bestelling.begintijd";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@IntValue", intValue);
            return ReadTablesDateTafel(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}