using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project1._4.DAL
{
    public class MenuProductDao : BaseDao
    {
        private List<Menu> ReadTables(DataTable dataTable)
        {
            List<Menu> menu = new List<Menu>();

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    Order order = new Order(
            //        );
            //    orders.Add(product);
            //}
            return menu;
        }
        

        public List<MenuProduct> GetAllMenuItems()
        {
            //Menu gegevens uit de database halen.
            string query = "SELECT * FROM Menu";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));
        }

        public MenuProduct GetMenuItemById(int id)
        {
            return null;
        }
        
        public void AddMenuItem(MenuProduct menu)
        {

        }

        public void UpdateMenuItem(MenuProduct menu)
        {

        }

        public void DeleteMenuItem(MenuProduct menu)
        {

        }
    }
}
