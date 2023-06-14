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

        private List<Product> LoadProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllProducts();
            return products;
        }

        private List<Order> LoadOrders()
        {
            OrderService service = new OrderService();
            List<Order> orders = service.GetAllOrders();
            return orders;
        }

        private List<OrderItem> LoadOrderItems()
        {
            OrderItemService service = new OrderItemService();
            List<OrderItem> orderItems = service.GetAllOrderItems();
            return orderItems;
        }

        private void AddProductToOrder(Product product) { }

        private void RemoveProductFromOrder(OrderItem orderItem) { }

        private void AddComment(OrderItem orderItem) { }

        private void GoToCategory() { }

        private void FinishOrder() { }

        private void testBtn_Click(object sender, EventArgs e)
        {
            List<Product> products = LoadProducts();
            products = LoadProducts();
            LoadOrderItems();
            LoadOrders();
            OrderViewUC orderViewFLP;
            foreach (Product product in products)
            {
                orderViewFLP = new OrderViewUC(product);
                this.OrderViewFLP.Controls.Add(orderViewFLP);
            }

        }
    }
}
