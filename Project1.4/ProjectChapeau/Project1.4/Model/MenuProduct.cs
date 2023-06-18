using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Model
{
    public class MenuProduct
    {
        public MenuProduct(int menuId, int productId)
        {
            MenuId = menuId;
            ProductId = productId;
        }

        public int MenuId { get; set; }
        public int ProductId { get; set; }
    }
}
