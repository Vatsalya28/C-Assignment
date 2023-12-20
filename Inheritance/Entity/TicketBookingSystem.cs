using System;
using System.Collections.Generic;
using Inheritance.Constants;

namespace Inheritance.Entity
{
    public class TicketBookingSystem
    {
        private List<Event> events = new List<Event>();

        public Event CreateEvent(string eventName, string date, string time, int totalSeats, float ticketPrice, string eventType, string venueName)
        {
            EventType type;
            Enum.TryParse(eventType, out type);

            Event newEvent;

            switch (type)
            {
                case EventType.Movie:
                    newEvent = new Movie(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, Convert.ToDecimal(ticketPrice), type, "", "", "");
                    break;
                case EventType.Concert:
                    newEvent = new Concert(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, Convert.ToDecimal(ticketPrice), type, "", "");
                    break;
                case EventType.Sports:
                    newEvent = new Sports(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, Convert.ToDecimal(ticketPrice), type, "", "");
                    break;
                default:
                    throw new ArgumentException("Invalid event type.");
            }

            events.Add(newEvent);
            return newEvent;
        }

        public void DisplayEventDetails(Event eventObj)
        {
            eventObj.DisplayEventDetails();
        }

        public float BookTickets(Event eventObj, int numTickets)
        {
            if (eventObj.AvailableSeats >= numTickets)
            {
                eventObj.AvailableSeats -= numTickets;
                return numTickets * (float)eventObj.TicketPrice;
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking. Event is sold out.");
                return 0;
            }
        }

        public void CancelTickets(Event eventObj, int numTickets)
        {
            eventObj.AvailableSeats += numTickets;
            Console.WriteLine($"{numTickets} tickets canceled for the event: {eventObj.EventName}");
        }
    }
}
