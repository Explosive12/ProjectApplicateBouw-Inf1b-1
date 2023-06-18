using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Service
{
    public class PaymentService
    {
        private PaymentDao orderDb;

        public PaymentService()
        {
            orderDb = new PaymentDao();
        }
        public void AddComment(string paymentcomment, int paymentId)
        {
            orderDb.AddComment(paymentcomment, paymentId);
        }
    }
}
