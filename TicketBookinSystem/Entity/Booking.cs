using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Booking
    {
        public int booking_id { get; set; }
        public int customer_id { get; set; }
        public int event_id { get; set; }
        public decimal total_cost { get; set; }
        public DateTime booking_date { get; set; }

        public override string ToString()
        {
            return $"Booking id:{booking_id},customer id:{customer_id},event_id:{event_id},totalCost:{total_cost},bookingDate:{booking_date}";
        }
    }
}
