using Project1._4.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Project1._4
{
    public class MenuDao : BaseDao
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

