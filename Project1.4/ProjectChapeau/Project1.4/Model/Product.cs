using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Product
    {
        public Product(int ProductId, string Name, decimal Price, int Stock, decimal Btw)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
            this.Btw = Btw;
        }
        public int ProductId { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal Btw { get; set; }
    }
}