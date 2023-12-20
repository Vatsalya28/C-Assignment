using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public enum EventType
    {
        Movie,Sport,Concert
    }
    public class Event
    {
        public int event_id { get; set; }
        public string event_name { get; set; }
        public DateTime event_date { get; set; }
        public TimeSpan event_time { get; set; }
        public int venue_id { get; set; }
        public string venue_name { get; set; }
        public int total_seats { get; set; }
        public int available_seats { get; set; }
        public decimal ticket_price { get; set; }
        public EventType event_type { get; set; }
        public int booking_id { get; set; }


        public override string ToString()
        {
            return $"Event Id:{event_id}\tEvent Name{event_name}\t Event Date:{event_date}\tEvent Time:{event_time}\tVenue Id:{venue_id}\tVenue Name:{venue_name}\tTotal Seats:{total_seats}\tAvailable Seats:{available_seats}\tTicket Price:{ticket_price}\tEvent Type:{event_type}\tBooking Id:{booking_id}";
            
        }

    }
}
