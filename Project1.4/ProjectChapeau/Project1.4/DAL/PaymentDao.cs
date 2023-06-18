using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Project1._4.DAL
{
    internal class PaymentDao : BaseDao
    {

        public void AddComment(string paymentComment, int paymentId) // geen return
        {
            string query =  "UPDATE [rekening] " +
                            "SET [comment] = @Comment " +
                            "WHERE [bestellingId] = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Comment", paymentComment);
            //sqlParameters[1] = new SqlParameter("@BestellingId", paymentId);
            ExecuteEditQuery(query, sqlParameters);

        }

      /*  public void AddComment(PaymentItem paymentItem)
        {
            string query = "UPDATE rekening SET comment = @comment WHERE rekeningId = @rekeningId";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            if (paymentItem.Comment == null)
                sqlParameters[0] = new SqlParameter("@comment", paymentItem.Comment);
            else
                sqlParameters[0] = new SqlParameter("@comment", DBNull.Value);

            sqlParameters[1] = new SqlParameter("@rekeningId", paymentItem.RekeningId);
            ExecuteEditQuery(query, sqlParameters);
        }
*/



    }

}
