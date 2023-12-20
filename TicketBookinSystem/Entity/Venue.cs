using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Venue
    {
        public int venue_id { get; set; }
        public string venue_name { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return $"Venue Id:{venue_id}\t Venue Name:{venue_name}\tVenue Address:{address}";
        }
    }
}
