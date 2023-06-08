using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Order
    {
        public Order(int OrderId, int TableId, DateTime BeginTime, DateTime EndTime)
        {
            this.OrderId = OrderId;
            this.TableId = TableId;
            this.BeginTime = BeginTime;
            this.EndTime = EndTime;
        }
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}