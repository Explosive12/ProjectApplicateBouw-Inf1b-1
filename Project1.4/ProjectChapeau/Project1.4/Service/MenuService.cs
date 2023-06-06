using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4
{
    public class MenuService
    {
        private MenuDao _menuDb;

        public MenuService()
        {
            _menuDb = new MenuDao();
        }
        
        public List<Menu> GetAllMenuItems()
        {
            throw new Exception();

        }
        public void InsertMenuItem()
        {

        }

        public void UpdateMenuItem()
        {

        }

        public void DeleteMenuItem()
        {

        }
    }
}