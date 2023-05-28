using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1._4.DAL;
using Project1._4.Model;

namespace Project1._4.Service
{
    public class ProductService
    {
        private ProductDao productDb;

        public ProductService()
        {
            this.productDb = new ProductDao();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = productDb.GetAllProducts();
            return products;
        }

        public List<Product> GetProductById(int productId)
        {
            List<Product> products = productDb.GetByIdProduct(productId);
            return products;
        }
    }

}