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

        public List<OrderItem> GetOrdersFromTable(int tableId)
        {
            return orderDao.GetOrdersFromTable(tableId);
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

        public int GetNextAvailableOrderId()
        {
            return orderDao.GetNextOrderAvailableId();
        }

        public void InsertOrder(Order order)
        {
            orderDao.InsertOrder(order);
        }

        public decimal GetProductPrice(int productId)
        {
            
            return orderDao.GetProductPrice(productId);
        }
        public int QuantityOfProduct(int productId)
        {
            orderDao.QuantityOfProduct(productId);
            return productId;
        }


    }


}