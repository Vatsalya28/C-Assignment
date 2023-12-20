using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Customer
    {
        public string customer_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public int booking_id { get; set; }

        public override string ToString()
        {
            return $"Customer Name:{customer_name}\tEmail{email}\tPhone Number:{phone_number}\tBooking Id:{booking_id}";
        }
    }
}
