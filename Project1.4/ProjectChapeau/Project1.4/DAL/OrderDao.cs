using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project1._4.DAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT bestellingId, tafelId, begintijd, eindtijd " +
                            "FROM bestelling";
            return ReadTables(ExecuteSelectQuery(query));
        }

        /* 
         *  GetOrdersFromTable
         *  via bestelling, rekening en bestelregel (zelfde als orderitem)
         *  
         *  voor bill UI loop door all order items en voeg het toe aan een list ofzo
         *  
         *  addcommand function in DAO
         */
        /* string query = "SELECT naam, aantal, prijs FROM bestelregel AS BR " +
                            "JOIN rekening AS R ON BR.id = R.rekeningId " +
                            "JOIN bestelling AS B ON R.bestellingId = B.bestellingId " +
                            "WHERE B.tafelId = @tableId";*/






        public List<OrderItem> GetOrdersFromTable(int productId)
        {
            string query = "SELECT p.naam, p.prijs, br.aantal FROM product p JOIN bestelregel br ON p.productId = br.productId JOIN bestelling b ON br.bestellingId = b.bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", productId);
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }





        /* public decimal TotalPrice { get; set; }*/

        // prijs per bestelling berekenen


        public decimal GetProductPrice(int productId)
        {
            string query = "SELECT p.prijs FROM product p JOIN bestelregel br ON p.productId = br.productId JOIN bestelling b ON br.bestellingId = b.bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", productId);
            return (decimal)ExecuteSelectQuery(query, sqlParameters).Rows[0]["prijs"];
        }

        public int QuantityOfProduct(int productId)
        {
            string query = "SELECT br.aantal FROM product p JOIN bestelregel br ON p.productId = br.productId JOIN bestelling b ON br.bestellingId = b.bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", productId);
            return (int)ExecuteSelectQuery(query, sqlParameters).Rows[0]["aantal"];
        }


        public List<Order> GetByIdOrder(int orderId)
        {
            string query = "SELECT bestellingId, tafelId, begintijd, eindtijd " +
                            "FROM bestelling " +
                            "WHERE bestellingId = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", orderId)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Income> GetPriceFromLast2Months()
        {
            string query = "SELECT top 2 SUM(prijs* aantal) as total, MONTH(B.begintijd) as month " +
                "FROM product P JOIN bestelregel R ON P.productId = R.productId JOIN bestelling B ON R.bestellingId = B.bestellingId   " +
                "group by year(B.begintijd),MONTH(B.begintijd)   " +
                "order by year(B.begintijd) desc ,MONTH(B.begintijd) desc";

            return ReadIncomes(query);
        }

        private List<Income> ReadIncomes(string query)
        {
            List<Income> incomes = new();
            DataTable datatable = ExecuteSelectQuery(query);
            foreach (DataRow dr in datatable.Rows)
            {
                Income income= new Income()
                {
                    Total = (decimal)dr["total"],
                    Month = (int)dr["month"]
                };
                incomes.Add(income);
            }
            return incomes;
        }

        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> orders = new List<OrderItem>();
           /* foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem(
                    (int)dr["OrderId"],
                    (int)dr["ProductId"],
                    (int)dr["Amount"],
                    dr["Comment"].ToString(),
                    (OrderStatusEnum)dr["Status"]
                );
                orders.Add(orderItem);
            }*/
            return orders;
        }

        private List<Order> ReadTables(DataTable dataTable)

        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order
                (
                    (int)dr["bestellingId"],
                    (int)dr["tafelId"],
                    (DateTime)dr["begintijd"],
                    (DateTime)dr["eindtijd"]
                );
                orders.Add(order);
            }
            return orders;
        }

        public int GetNextOrderAvailableId()
        {
            string query = "SELECT COUNT(*) FROM bestelling";
            int count = ReadCountTable(ExecuteSelectQuery(query)) + 1;
            return count;
        }

        private int ReadCountTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            int count = (int)dr[0];
            return count;
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
            string query = "DELETE FROM bestelling " +
                            "WHERE id = @orderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", order.OrderId)
            };
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
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}