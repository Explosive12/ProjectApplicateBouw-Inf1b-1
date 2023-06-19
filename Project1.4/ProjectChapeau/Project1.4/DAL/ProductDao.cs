using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using Project1._4.Model;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Project1._4.DAL
{
    public class ProductDao : BaseDao
    {
        public List<Product> GetAllProducts()
        {
            string query = "SELECT productId, naam, prijs, voorraad, btw, productType FROM product";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<Product> GetAllLunchProducts()
        {
            string query = "SELECT P.productId, naam, prijs, voorraad, btw, productType FROM product AS P " +
                            "JOIN menu AS M ON P.productId = M.productId " +
                            "WHERE M.type='Lunch'";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<Product> GetAllDinnerProducts()
        {
            string query = "SELECT P.productId, naam, prijs, voorraad, btw, productType FROM product AS P " +
                            "JOIN menu AS M ON P.productId = M.productId " +
                            "WHERE M.type='Dinner'";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<Product> GetAllDrinksProducts()
        {
            string query = "SELECT P.productId, naam, prijs, voorraad, btw, productType FROM product AS P " +
                            "JOIN menu AS M ON P.productId = M.productId " +
                            "WHERE M.type='Drinks'";
            return ReadTables(ExecuteSelectQuery(query));
        }

        

        public List<Product> GetByIdProduct(int productId)
        {
            string query = "SELECT productId, naam, prijs, voorraad, btw, productType FROM product WHERE productId = @productId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", productId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private ProductType GetProductType(int productType)
        {
            switch (productType)
            {
                case 1:
                    return ProductType.Entree;
                case 2:
                    return ProductType.SideDish;
                case 3:
                    return ProductType.MainCourse;
                case 4:
                    return ProductType.Dessert;
                case 13:
                    return ProductType.SoftDrinks;
                case 10:
                    return ProductType.Beer;
                case 11:
                    return ProductType.Wine;
                case 12:
                    return ProductType.Spirit;
                case 14:
                    return ProductType.CoffeeAndTea;
                default:
                    return ProductType.Entree;
            }
        }
        private List<Product> ReadTables(DataTable dataTable)
        {
            List<Product> products = new List<Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ProductType productType = GetProductType((int)dr[5]);

                Product product = new Product(
                    (int)dr[0],         //id
                    dr[1].ToString(),   // name
                    (decimal)dr[2],     // price
                    (int)dr[3],         // Stock
                    (decimal)dr[4],     // btw
                    productType         // productType
                    );
                products.Add(product);
            }
        
            return products;
        }


        // From the management

        public void AddProduct  (Product product)
        {
            string query = "INSERT INTO product (naam, prijs, voorraad, btw, productType) VALUES (@naam, @prijs, @voorraad, @btw, @productType)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            {
                sqlParameters[0] = new SqlParameter("@naam", product.Name);
                sqlParameters[1] = new SqlParameter("@prijs", product.Price);
                sqlParameters[2] = new SqlParameter("@voorraad", product.Stock);
                sqlParameters[3] = new SqlParameter("@btw", product.Btw);
                sqlParameters[4] = new SqlParameter("@productType", product.Type);
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteProduct(Product product)
        {
            string query = "DELETE FROM product WHERE productId = @productId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", product.ProductId);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateProduct(Product product)
        {
            string query = "UPDATE product SET naam = @naam, prijs = @prijs, voorraad = @voorraad, btw = @btw, productType = @productType WHERE productId = @productId";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            {
                sqlParameters[0] = new SqlParameter("@productId", product.ProductId);
                sqlParameters[1] = new SqlParameter("@naam", product.Name);
                sqlParameters[2] = new SqlParameter("@prijs", product.Price);
                sqlParameters[3] = new SqlParameter("@voorraad", product.Stock);
                sqlParameters[4] = new SqlParameter("@btw", product.Btw);
                sqlParameters[5] = new SqlParameter("@productType", product.Type);

            }
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateProductStockList(List<Product> products)
        {
            string query = "UPDATE product SET voorraad = @voorraad WHERE productId = @productId";
            foreach (Product product in products)
            {
                SqlParameter[] sqlParameters = new SqlParameter[2];
                {
                    sqlParameters[0] = new SqlParameter("@productId", product.ProductId);
                    sqlParameters[1] = new SqlParameter("@voorraad", product.Stock);
                }
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}