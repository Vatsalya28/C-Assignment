using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Concert : Event
    {
        // Additional attributes for Concert class
        public string Artist { get; set; }
        public string Type { get; set; }

      
        public Concert()
        {
            event_type = EventType.Concert;
        }

        
        public Concert(int customerId, string customerName, string artist, string type)
        {
            
            Artist = artist;
            Type = type;

            event_type = EventType.Concert;
        }

        public void display_concert_details()
        {
            Console.WriteLine($"Concert Details:\nArtist: {Artist}\nType: {Type}\n{base.ToString()}");
        }
    }
}
