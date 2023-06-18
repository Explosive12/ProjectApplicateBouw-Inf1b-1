using Project1._4.DAL;
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

        // Get all OrderItems related to dinner/lunch orders
        public List<OrderItem> GetOrderItemsByDinnerLunch()
        {
            List<OrderItem> list = orderItemDb.GetOrderItemsByDinnerLunch();
            return list;
        }

        // Get all OrderItems related to drink orders
        public List<OrderItem> GetOrderItemsByDrink()
        {
            List<OrderItem> list = orderItemDb.GetOrderItemsByDrinks();
            return list;
        }

        // Get OrderItem by its ID
        public List<OrderItem> GetByOrderItemId(int orderItemId)
        {
            List<OrderItem> list = orderItemDb.GetByOrderItemId(orderItemId);
            return list;
        }

        // Get OrderItems by kitchen status
        public List<OrderItem> GetByStatusKitchen(int intValue)
        {
            List<OrderItem> list = orderItemDb.GetByStatusKitchen(intValue);
            return list;
        }

        // Get OrderItems by bar order status
        public List<OrderItem> GetByStatusBar(int intValue)
        {
            List<OrderItem> list = orderItemDb.GetByStatusBar(intValue);
            return list;
        }

        // Update the status of an OrderItem
        public void UpdateOrderItemStatus(int clickedData, int state)
        {
            orderItemDb.UpdateOrderItemState(clickedData, state);
        }
    }
}