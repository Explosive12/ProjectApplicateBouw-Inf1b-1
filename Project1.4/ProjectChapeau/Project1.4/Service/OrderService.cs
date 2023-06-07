using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Service
{
    public class OrderService
    {
        private OrderDao orderDb;

        public OrderService()
        {
            orderDb = new OrderDao();
        }

        public List<Order> GetAllOrders()
        {
            List<Order> list = orderDb.GetAllOrders();
            return list;
        }

        public List<Order> GetByIdOrder(int orderId)
        {
            List<Order> list = orderDb.GetByIdOrder(orderId);
            return list;
        }

        public void InsertOrder(Order order)
        {
            orderDb.InsertOrder(order);
        }
        public void RemoveOrder(Order order)
        {
            orderDb.RemoveOrder(order);
        }
        public void UpdateOrder(Order order)
        {
            orderDb.RemoveOrder(order);
        }
    }
}