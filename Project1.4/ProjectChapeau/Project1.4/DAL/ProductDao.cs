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
            string query = "SELECT productId, naam, prijs, voorraad, btw FROM product";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Product> GetByIdProduct(int productId)
        {
            string query = "SELECT productId, naam, prijs, voorraad, btw FROM product WHERE productId = @productId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@productId", productId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Product> ReadTables(DataTable dataTable)
        {
            List<Product> products = new List<Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Product product = new Product(
                    (int)dr["productId"],
                    (string)dr["naam"],
                    (decimal)dr["prijs"],
                    (int)dr["voorraad"],
                    (decimal)dr["btw"]
                    );
                products.Add(product);
            }
            return products;
        }

        
    }
}