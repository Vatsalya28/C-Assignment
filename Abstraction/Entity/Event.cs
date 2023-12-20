using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Constant;
namespace Abstraction.Entity
{
    public abstract class Event
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

        public abstract void DisplayEventDetails();

        public override string ToString()
        {
            return $"{EventName} - {EventDate.ToShortDateString()} {EventTime}";
        }

        public decimal CalculateTotalRevenue()
        {
            return (TotalSeats - AvailableSeats) * TicketPrice;
        }

        public int GetBookedNoOfTickets()
        {
            return TotalSeats - AvailableSeats;
        }

        public void BookTickets(int numTickets)
        {
            if (AvailableSeats >= numTickets)
            {
                AvailableSeats -= numTickets;
                Console.WriteLine($"{numTickets} tickets booked for the event: {EventName}");
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking.");
            }
        }

        public void CancelBooking(int numTickets)
        {
            AvailableSeats += numTickets;
            Console.WriteLine($"{numTickets} tickets canceled for the event: {EventName}");
        }
    }
}
