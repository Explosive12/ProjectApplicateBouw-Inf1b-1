using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1._4.Service;
using Project1._4.Model;

namespace Project1._4
{
    public partial class OrderView : Form
    {
        public OrderView()
        {
            InitializeComponent();
        }

        public List<Product> LoadProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllProducts();
            return products;
        }

        public List<Order> LoadOrders()
        {
            OrderService service = new OrderService();
            List<Order> orders = service.GetAllOrders();
            return orders;
        }

        public void AddProductToOrder(Product product) { }

        public void RemoveProductFromOrder(OrderItem orderItem) { }

        public void AddComment(OrderItem orderItem) { }

        public void GoToCategory() { }

        public void FinishOrder() { }
    }
}
