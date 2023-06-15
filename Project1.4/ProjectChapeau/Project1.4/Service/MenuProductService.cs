using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Service
{
    public class MenuProductService
    {
        private MenuProductDao _menuProductDb;

        public MenuProductService()
        {
            _menuProductDb = new MenuProductDao();
        }

        public List<MenuProduct> GetAllMenuItems()
        {
            List<MenuProduct> menuProducts = _menuProductDb.GetAllMenuItems();
            return menuProducts;
        }

        public MenuProduct GetMenuItemById(int menuId)
        {
            MenuProduct menuItem = _menuProductDb.GetMenuItemById(menuId);
            return menuItem;
        }

        public void AddMenuItem(MenuProduct menu)
        {
            _menuProductDb.AddMenuItem(menu);
        }

        public void DeleteMenuItem(MenuProduct menu)
        {
            _menuProductDb.DeleteMenuItem(menu);
        }

        public void UpdateMenuItem(MenuProduct menu)
        {
            _menuProductDb.UpdateMenuItem(menu);
        }
    }
}
