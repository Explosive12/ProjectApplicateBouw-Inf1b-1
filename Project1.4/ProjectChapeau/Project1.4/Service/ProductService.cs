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

        public void AddProduct(Product product)
        {
            productDb.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productDb.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            productDb.DeleteProduct(product);
        }

        
    }

}