using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4.UI
{
    public partial class BarKitchenView : Form
    {
        //private Order order = new Order();
        public BarKitchenView()
        {
            InitializeComponent();
        }
        public void Loadabc()
        {
            Order kitchenOrder = GenerateNewKitchenOrder();
            KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);

            this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
        }
        private void ChangeStatus()
        {

        }

        public List<Order> LoadOrders()
        {
            OrderService service = new OrderService();
            List<Order> orders = service.GetAllOrders();
            return orders;
        }

        public List<OrderItem> LoadOrderItems()
        {
            OrderItemService service = new OrderItemService();
            List<OrderItem> orderItems = service.GetAllOrderItems();
            return orderItems;
        }

        private Order GenerateNewKitchenOrder()
        {
            Random random = new Random();

            int orderId = random.Next(0, 100);
            int tableId = random.Next(0, 100);
            DateTime beginTime = DateTime.Now;
            DateTime endTime = DateTime.Now;

            Order kitchenOrder = new Order(orderId, tableId, beginTime, endTime);
            return kitchenOrder;
        }

        private void btnLoadKitchenOrders_Click(object sender, EventArgs e)
        {
            Order kitchenOrder = GenerateNewKitchenOrder();
            KitchenOrderControl kitchenOrderControl = new KitchenOrderControl(kitchenOrder);

            this.flpKitchenOrders.Controls.Clear();
            this.flpKitchenOrders.Controls.Add(kitchenOrderControl);
        }

        private void btnKitchenToMain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            // Create an instance of the new form
            LoginView loginview = new LoginView();
            BarKitchenView barKitchenView = new BarKitchenView();

            // Show the new form
            form1.Show();

            this.Hide();
        }
    }
}
