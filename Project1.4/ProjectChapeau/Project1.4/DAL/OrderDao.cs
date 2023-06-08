﻿using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Project1._4.DAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT bestellingId, tafelId, begintijd, eindtijd FROM bestelling";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetByIdOrder(int orderId)
        {
            string query = "SELECT bestellingId, tafelId, begintijd, eindtijd FROM bestelling WHERE bestellingId = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderId", orderId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)

        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order(
                    (int)dr["bestellingId"],
                    (int)dr["tafelId"],
                    (DateTime)dr["begintijd"],
                    (DateTime)dr["eindtijd"]
                    );
                orders.Add(order);
            }
            return orders;
        }


        public void InsertOrder(Order order)
        {
            string query = "INSERT INTO bestelling (bestellingId, tafelId, begintijd, eindtijd) " +
                                "VALUES (@orderId, @tableId, @beginTime, @endTime)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", order.OrderId),
                new SqlParameter("@tableId", order.TableId),
                new SqlParameter("@beginTime", order.BeginTime),
                new SqlParameter("@endTime", order.EndTime),


            };
            ExecuteEditQuery(query, sqlParameters);

        }
        
        public void RemoveOrder(Order order)
        {
            string query = "DELETE FROM bestelling WHERE id = @orderId";
            SqlParameter[] sqlParameters = { new SqlParameter("@orderId", order.OrderId) };
            ExecuteEditQuery(query, sqlParameters);
        }
        
        public void UpdateOrder(Order order)
        {
            string query = "UPDATE bestelling" +
                                "SET bestellingId = @orderId, tafelId = @tableId, begintijd = @beginTime, eindtijd = @endTime" +
                                "WHERE bestellingId = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", order.OrderId),
                new SqlParameter("@tableId", order.TableId),
                new SqlParameter("@beginTime", order.BeginTime),
                new SqlParameter("@endTime", order.EndTime)
            };
        }
    }
}