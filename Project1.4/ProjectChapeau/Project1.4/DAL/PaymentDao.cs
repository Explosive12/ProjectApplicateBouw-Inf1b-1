using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.DAL
{
    internal class PaymentDao : BaseDao
    {

      /*  public List<Order> GetAllOrders()
        {
            string query = "SELECT bestellingId, tafelId, begintijd, eindtijd FROM bestelling";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }*/

        /* public List<Order> GetByIdOrder(int orderId)
         {
             string query = "SELECT bestellingId, tafelId, begintijd, eindtijd FROM bestelling WHERE bestellingId = @orderId";
             SqlParameter[] sqlParameters = new SqlParameter[1];
             sqlParameters[0] = new SqlParameter("@orderId", orderId);
             return ReadTables(ExecuteSelectQuery(query, sqlParameters));
         }
         private List<OrderItem> ReadTables(DataTable dataTable)
         {
             List<OrderItem> orderItems = new List<OrderItem>();

             foreach (DataRow dr in dataTable.Rows)
             {
                 OrderItem orderItem = new OrderItem(
                     (int)dr["id"],
                     (int)dr["bestellingId"],
                     (int)dr["productId"],
                     (int)dr["aantal"],
                     (string)dr["opmerking"],
                     (OrderStatusEnum)dr["status"]
                     );
                 orderItems.Add(orderItem);
             }
             return orderItems;
         }
 */





    }

}
