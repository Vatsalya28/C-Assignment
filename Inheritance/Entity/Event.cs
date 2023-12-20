using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Constants;

namespace Inheritance.Entity
{
    public class Event
    {

        private string eventName;
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        private DateTime eventDate;
        public DateTime EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        private TimeSpan eventTime;
        public TimeSpan EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

        private string venueName;
        public string VenueName
        {
            get { return venueName; }
            set { venueName = value; }
        }

        private int totalSeats;
        public int TotalSeats
        {
            get { return totalSeats; }
            set { totalSeats = value; }
        }

        private int availableSeats;
        public int AvailableSeats
        {
            get { return availableSeats; }
            set { availableSeats = value; }
        }

        private decimal ticketPrice;
        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }

        EventType eventType;
        public EventType EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }



        public Event(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            VenueName = venueName;
            TotalSeats = totalSeats;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
            EventType = eventType;
        }


        public void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Venue Name: {VenueName}");
            Console.WriteLine($"Total Seats: {TotalSeats}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice:C}");
            Console.WriteLine($"Event Type: {EventType}");
        }

        public override string ToString()
        {
            return $"{EventName} - {EventDate.ToShortDateString()} {EventTime}";
        }
    }
}
