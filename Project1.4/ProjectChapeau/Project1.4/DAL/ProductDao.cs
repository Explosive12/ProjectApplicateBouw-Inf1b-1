using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using Project1._4.Model;

namespace Project1._4.DAL
{
    public class ProductDao : BaseDao
    {
        // get all items from table
        public List<Product> GetAllProducts()
        {
            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return new List<Product>(); // remove this, this is just to prevent errors
        }

        private List<Product> ReadTables(DataTable dataTable)
        {
            List<Product> products = new List<Product>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Product product = new Product(
            //        );
            //    products.Add(product);
            //}
            return products;
        }

        public List<Product> GetByIdProduct(int productId)
        {
            //string query = "";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //return ReadTablesSupervisor(ExecuteSelectQuery(query, sqlParameters));
            return new List<Product>(); // remove this, this is just to prevent errors
        }

        public void InsertMenuItem()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveMenuItem()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMenuItem()
        {
            throw new System.NotImplementedException();
        }
    }
}