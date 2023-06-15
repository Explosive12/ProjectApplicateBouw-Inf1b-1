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

        public List<OrderItem> GetOrderItemsByDinnerLunch()
        {
            List<OrderItem> list = orderItemDb.GetOrderItemsByDinnerLunch();
            return list;
        }

        public List<OrderItem> GetByOrderItemId(int orderItemId)
        {
            List<OrderItem> list = orderItemDb.GetByOrderItemId(orderItemId);
            return list;
        }

        public void UpdateOrderItemStatus(int clickedData, int state)
        {
            orderItemDb.UpdateOrderItemState(clickedData, state);
        }
    }
}