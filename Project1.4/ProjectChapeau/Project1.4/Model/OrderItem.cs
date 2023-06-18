using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class OrderItem
    {
        public OrderItem(int orderItemId, int orderId, int productId, int amount, string comment, OrderStatusEnum status, DateTime beginTime, int tableNumber)
        {
            OrderItemId = orderItemId;
            OrderId = orderId;
            ProductId = productId;
            Comment = comment;
            Amount = amount;
            Status = status;
            BeginTime = beginTime;
            TableNumber = tableNumber;
        }

        public OrderItem(int orderItemId, int orderId, int productId, int amount, string comment, OrderStatusEnum status)
        {
            OrderItemId = orderItemId;
            OrderId = orderId;
            ProductId = productId;
            Comment = comment;
            Amount = amount;
            Status = status;
        }

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int Amount { get; set; }
        public OrderStatusEnum Status { get; set; }
        public DateTime BeginTime { get; set; }
        public int TableNumber { get; set; }
    }
}