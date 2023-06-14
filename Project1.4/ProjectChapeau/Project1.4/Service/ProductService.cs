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

        public List<Product> GetAllLunchProducts()
        {
            List<Product> products = productDb.GetAllLunchProducts();
            return products;
        }

        public List<Product> GetAllDinnerProducts()
        {
            List<Product> products = productDb.GetAllDinnerProducts();
            return products;
        }

        public List<Product> GetAllDrinksProducts()
        {
            List<Product> products = productDb.GetAllDrinksProducts();
            return products;
        }
    }

}