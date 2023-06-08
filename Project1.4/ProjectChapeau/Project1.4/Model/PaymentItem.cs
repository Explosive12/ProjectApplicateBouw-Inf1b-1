using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Model
{
    public class PaymentItem
    {
        public int TafelId { get; set; }
        public int BestellingId { get; set; }   
        public int RekeningId { get; set; }
        public int Aantal { get; set; }

        public int Fooi { get; set; }
        public decimal Prijs { get; set; }
        public decimal TotaalPrijs { get; set; }



    }
}
