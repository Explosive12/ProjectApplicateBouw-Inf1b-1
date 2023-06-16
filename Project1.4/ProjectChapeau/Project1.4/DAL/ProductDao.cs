using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using Project1._4.Model;
using System.Data.SqlClient;

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
                            "JOIN menu AS M ON P.productId = M.productId" +
                            "WHERE M.type='Dinner'";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<Product> GetAllDrinksProducts()
        {
            string query = "SELECT P.productId, naam, prijs, voorraad, btw, productType FROM product AS P " +
                            "JOIN menu AS M ON P.productId = M.productId" +
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
        private ProductType GetProductType(string productType)
        {
            switch (productType)
            {
                case "Entree":
                    return ProductType.Entree;
                case "MainCourse":
                    return ProductType.MainCourse;
                case "Dessert":
                    return ProductType.Dessert;
                case "SideDish":
                    return ProductType.SideDish;
                case "SoftDrinks":
                    return ProductType.SoftDrinks;
                case "Beer":
                    return ProductType.Beer;
                case "Wine":
                    return ProductType.Wine;
                case "Spirit":
                    return ProductType.Spirit;
                case "CoffeeAdnTea":
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
                ProductType productType = GetProductType(dr["productType"].ToString());

                Product product = new Product(
                    (int)dr["productId"], //id
                    dr["naam"].ToString(), // name
                    (decimal)dr["prijs"], // price
                    (int)dr["voorraad"], // Stock
                    (decimal)dr["btw"], // btw
                    productType         // productType
                    );
                products.Add(product);
            }
        
            return products;
        }


        // From the management

        public void AddProduct(Product product)
        {
            string query = "INSERT INTO product (naam, prijs, voorraad, btw, productType) VALUES (@naam, @prijs, @voorraad, @btw, @productType)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@naam", product.Name);
            sqlParameters[1] = new SqlParameter("@prijs", product.Price);
            sqlParameters[2] = new SqlParameter("@voorraad", product.Stock);
            sqlParameters[3] = new SqlParameter("@btw", product.Btw);
            sqlParameters[4] = new SqlParameter("@productType", product.Type);
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
            
            
        }
    }
}