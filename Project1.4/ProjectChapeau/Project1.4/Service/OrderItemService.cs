﻿using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Service
{
    public class OrderItemService
    {
        private OrderItemDao orderItemDb;

        public OrderItemService()
        {
            orderItemDb = new OrderItemDao();
        }

        public List<OrderItem> GetAllOrderItems()
        {
            List<OrderItem> list = orderItemDb.GetAllOrderItems();
            return list;
        }

        public List<OrderItem> GetByIdOrderItem(int orderItemId)
        {
            List<OrderItem> list = orderItemDb.GetByIdOrderItem(orderItemId);
            return list;
        }

        public void InsertOrderItem(List<OrderItem> orderItems)
        {
            orderItemDb.InsertOrderItems(orderItems);
        }
        public void RemoveOrderItem(OrderItem orderItem)
        {
            orderItemDb.RemoveOrderItem(orderItem);
        }
        public void UpdateOrderItem(OrderItem orderItem)
        {
            orderItemDb.UpdateOrderItem(orderItem);
        }
    }
}