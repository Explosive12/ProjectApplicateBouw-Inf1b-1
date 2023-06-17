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

        public void AddComment(PaymentItem paymentItem) // geen return
        {
            string query = "UPDATE rekening SET comment = @comment WHERE rekeningId = @rekeningId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@comment", paymentItem.Comment);
            sqlParameters[1] = new SqlParameter("@rekeningId", paymentItem.RekeningId);
            ExecuteEditQuery(query, sqlParameters);

        }

        

    }

}
