using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Model
{
    public class Product
    {
        public Product(int productId, string name, decimal price, int stock, decimal btw, ProductType productType)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Btw = btw;
            this.Type = productType;
        }
        public int ProductId { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal Btw { get; set; }
    }
}