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
        private List<MenuProduct> ReadTables(DataTable dataTable)
        {
            List<MenuProduct> menu = new List<MenuProduct>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuProduct menuItem = new MenuProduct((int)dr[0], (int)dr[1]);
                menu.Add(menuItem);
            }
            return menu;
        }
        
        
        public List<MenuProduct> GetAllMenuItems()
        {
            //Menu gegevens uit de database halen.
            string query = "SELECT productId, menuId FROM MenuProducts";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, parameters));

        }

        public MenuProduct GetMenuItemById(int id)
        {
            //Menu gegevens uit de database halen via id.
            string query = "SELECT productId, menuId FROM MenuProducts WHERE menuId = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            return ReadTables(ExecuteSelectQuery(query, parameters))[0];
        }
        
        public void AddMenuItem(MenuProduct menu)
        {
            // Menu gegevens toevoegen aan de database.

            string query = "INSERT INTO MenuProducts (productId, menuId) VALUES (@productId, @menuId)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@productId", menu.ProductId);
            parameters[1] = new SqlParameter("@menuId", menu.MenuId);
            ExecuteEditQuery(query, parameters);

        }

        public void UpdateMenuItem(MenuProduct menu)
        {
            // Menu gegevens updaten in de database.
            string query = "UPDATE MenuProducts SET productId = @productId, menuId = @menuId WHERE menuId = @menuId";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@productId", menu.ProductId);
            parameters[1] = new SqlParameter("@menuId", menu.MenuId);
            ExecuteEditQuery(query, parameters);

        }

        public void DeleteMenuItem(MenuProduct menu)
        {
            // Menu gegevens verwijderen uit de database.
            string query = "DELETE FROM MenuProducts WHERE menuId = @menuId";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@menuId", menu.MenuId);
            ExecuteEditQuery(query, parameters);

        }
    }
}
