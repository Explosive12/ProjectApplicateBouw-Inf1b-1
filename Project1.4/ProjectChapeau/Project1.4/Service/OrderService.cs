using Project1._4.DAL;
using Project1._4.Model;

namespace Project1._4.Service
{
    public class OrderService
    {
        private OrderDao orderDao;

        public OrderService()
        {
            orderDao = new OrderDao();
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = orderDao.GetAllOrders();
            return orders;
        }

        public List<Order> GetByIdOrder(int orderId)
        {
            List<Order> orders = orderDao.GetByIdOrder(orderId);
            return orders;
        }

        public List<Income> GetPriceFromLast2Months()
        {
            List<Income> incomes = orderDao.GetPriceFromLast2Months();
            return incomes;
        }

        public void InsertOrder(Order order)
        {
            //orderDb.InsertOrder(order);
        }
        public void RemoveOrder(Order order)
        {
            //orderDb.RemoveOrder(order);
        }
        public void UpdateOrder(Order order)
        {
            //orderDb.RemoveOrder(order);
        }
    }
}