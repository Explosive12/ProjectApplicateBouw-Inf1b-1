using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Model
{
    public class Menu
    {
        public Menu(int id, int productId, string name)
        {
            Id = id;
            ProductId = productId;
            Name = name;
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
}
