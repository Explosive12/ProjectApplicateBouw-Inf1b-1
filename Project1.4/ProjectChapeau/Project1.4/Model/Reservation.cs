using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1._4.Model
{
    public class Reservation
    {
        public int reservationId { get; set; }
        public int phoneNumber { get; set; }
        public string naam { get; set; }
        public int opmerking { get; set; }
        public DateTime datum { get; set; }
        public DateTime tijd { get; set; }
        public Reservation(int phoneNumber, string naam, int opmerking, DateTime datum, DateTime tijd)
        {
            this.phoneNumber = phoneNumber;
            this.naam = naam;
            this.opmerking = opmerking;
            this.datum = datum;
            this.tijd = tijd;
        }
        public Reservation()
        {
        }
    }
}
