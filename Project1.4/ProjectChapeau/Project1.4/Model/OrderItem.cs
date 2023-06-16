using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class OrderItem
    {
        public OrderItem(int OrderItemId, int OrderId, int ProductId, int Amount, string Comment, OrderStatusEnum status, DateTime beginTime)
        {
            this.OrderItemId = OrderItemId;
            this.OrderId = OrderId;
            this.ProductId = ProductId;
            this.Comment = Comment;
            this.Amount = Amount;
            this.Status = status;
            this.BeginTime =BeginTime;
        }
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int Amount { get; set; }
        public OrderStatusEnum Status { get; set; }
        public DateTime BeginTime { get; set; }
    }
}