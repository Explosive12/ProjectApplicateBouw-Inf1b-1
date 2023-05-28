using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public string Comment { get; set; }
        public int Amount { get; set; }
    }
}