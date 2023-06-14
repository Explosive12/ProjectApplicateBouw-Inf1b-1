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
using Project1._4.UI;

namespace Project1._4
{
    public partial class OrderViewLunch : Form
    {

        List<OrderItem> items = new List<OrderItem>();
        public OrderViewLunch()
        {
            InitializeComponent();
        }

        private void DisplayLunchProducts()
        {
            List<Product> products = LoadLunchProducts();
            List<Product> entreeProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.Entree);
            List<Product> mainCourseProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.MainCourse);
            List<Product> dessertProducts = SortLunchProductsOnType(new List<Product>(products), ProductTypeEnum.Dessert);

            OrderViewUC orderViewFLP;
            foreach (Product product in entreeProducts)
            {
                orderViewFLP = new OrderViewUC(product);
                this.OrderViewStarterFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in mainCourseProducts)
            {
                orderViewFLP = new OrderViewUC(product);
                this.OrderViewMainFLP.Controls.Add(orderViewFLP);
            }
            foreach (Product product in dessertProducts)
            {
                orderViewFLP = new OrderViewUC(product);
                this.OrderViewDessertsFLP.Controls.Add(orderViewFLP);
            }
        }

        private List<Product> SortLunchProductsOnType(List<Product> products, ProductTypeEnum productType)
        {
            List<Product> productsCopy = new List<Product>(products); // Create a copy of the products list so it doesnt get modified during a foreach loop

            foreach (Product product in productsCopy)
            {
                if (product.ProductType != productType)
                    products.Remove(product);
            }

            return products;
        }

        private List<Menu> LoadMenu()
        {
            MenuService service = new MenuService();
            List<Menu> menuList = service.GetAllMenuItems();
            return menuList;
        }

        private List<Product> LoadLunchProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllLunchProducts();
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

        public void AddProductToOrder(Product product) 
        {
            OrderItem orderItem = new OrderItem();
            items.Add(product);
        }

        private void RemoveProductFromOrder(OrderItem orderItem) { }

        private void AddComment(OrderItem orderItem) { }

        private void FinishOrder() { }

        private void orderViewGoToDinnerBtn_Click(object sender, EventArgs e)
        {
            OrderViewDinner orderView = new OrderViewDinner();
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToDrinksBtn_Click(object sender, EventArgs e)
        {
            OrderViewDrinks orderView = new OrderViewDrinks();
            orderView.Show();
            this.Hide();
        }

        private void orderViewGoToLunchBtn_Click(object sender, EventArgs e)
        {
            OrderViewLunch orderView = new OrderViewLunch();
            orderView.Show();
            this.Hide();
        }

        private void OrderViewLunch_Load(object sender, EventArgs e)
        {
            DisplayLunchProducts();
        }
    }
}
