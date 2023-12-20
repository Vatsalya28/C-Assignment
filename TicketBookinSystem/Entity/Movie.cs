using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Movie : Event
    {
       
        public string Genre { get; set; }
        public string ActorName { get; set; }
        public string ActressName { get; set; }

       
        public Movie()
        {
            event_type = EventType.Movie;
        }

        
        public Movie(int customerId, string customerName, string genre, string actorName, string actressName)
        {
            
            Genre = genre;
            ActorName = actorName;
            ActressName = actressName;

            event_type = EventType.Movie;
        }

        public void display_event_details()
        {
            Console.WriteLine($"Movie Details:\nGenre: {Genre}\nActor: {ActorName}\nActress: {ActressName}\n{base.ToString()}");
        }
    }

}
