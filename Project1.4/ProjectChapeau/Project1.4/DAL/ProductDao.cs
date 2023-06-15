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

            ProductType productType = GetProductType(dataTable.Rows[0]["productType"].ToString());

            foreach (DataRow dr in dataTable.Rows)
            {

                Product product = new Product(
                    (int)dr["productId"],
                    dr["naam"].ToString(),
                    (decimal)dr["prijs"],
                    (int)dr["voorraad"],
                    (decimal)dr["btw"],
                    productType
                    );
                products.Add(product);
            }
        
            return products;
        }




    }
}