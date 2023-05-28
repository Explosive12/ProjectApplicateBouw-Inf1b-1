using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> OrderList { get; set; }
        public int TableId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}