using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Constant;
namespace Abstraction.Entity
{
    public class TicketBookingSystem : BookingSystem
    {
        public List<Event> events = new List<Event>();

        public override Event CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, string venueName)
        {
            Event newEvent;

            switch (eventType.ToLower())
            {
                case "movie":
                    newEvent = new Movie(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, ticketPrice, EventType.Movie, "Action", "John Doe", "Jane Doe");
                    break;
                case "concert":
                    newEvent = new Concert(eventName, DateTime.Parse(date), TimeSpan.Parse(time),  venueName, totalSeats, totalSeats,  ticketPrice, "Artist Name", "Pop");
                    break;
                case "sports":
                    newEvent = new Sports(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, ticketPrice, EventType.Sports, "Football", "Team A vs Team B");
                    break;
                default:
                    throw new ArgumentException("Invalid event type.");
            }

            events.Add(newEvent);
            return newEvent;
        }

        public override void DisplayEventDetails(Event eventObj)
        {
            eventObj.DisplayEventDetails();
        }

        public override decimal BookTickets(Event eventObj, int numTickets)
        {
            if (eventObj.AvailableSeats >= numTickets)
            {
                eventObj.AvailableSeats -= numTickets;
                Console.WriteLine($"{numTickets} tickets booked for the event: {eventObj.EventName}");
                return numTickets * eventObj.TicketPrice;
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking.");
                return 0;
            }
        }

        public override void CancelTickets(Event eventObj, int numTickets)
        {
            eventObj.AvailableSeats += numTickets;
            Console.WriteLine($"{numTickets} tickets canceled for the event: {eventObj.EventName}");
        }
    }
}
