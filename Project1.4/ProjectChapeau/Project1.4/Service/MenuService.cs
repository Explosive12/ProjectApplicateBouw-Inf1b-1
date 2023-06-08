using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project1._4.DAL;
using Project1._4.Model;

namespace Project1._4.Service
{
    public class MenuService
    {
        private MenuDao menuDb;

        public MenuService()
        {
            menuDb = new MenuDao();
        }

        public List<Menu> GetAllMenuItems()
        {
            List<Menu> list = menuDb.GetAllMenuItems();
            return list;
        }

        public Menu GetMenuItemById(int menuId)
        {
            Menu menuItem = menuDb.GetMenuItemById(menuId);
            return menuItem;
        }

        public void AddMenuItem(Menu menu)
        {
            menuDb.AddMenuItem(menu);
        }

        public void DeleteMenuItem(Menu menu)
        {
            menuDb.DeleteMenuItem(menu);
        }

        public void UpdateMenuItem(Menu menu)
        {
            menuDb.UpdateMenuItem(menu);
        }

    }
}