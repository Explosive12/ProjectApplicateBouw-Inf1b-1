using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project1._4.DAL
{
    public class MenuDao : BaseDao
    {
        private List<Menu> ReadTables(DataTable dataTable)
        {
            List<Menu> menu = new List<Menu>();
            return menu;
        }


        public List<Menu> GetAllMenuItems()
        {
            return null;
        }

        public Menu GetMenuItemById(int id)
        {
            return null;
        }

        public void AddMenuItem(Menu menu)
        {

        }

        public void UpdateMenuItem(Menu menu)
        {

        }

        public void DeleteMenuItem(Menu menu)
        {

        }
    }
}