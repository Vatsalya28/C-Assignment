using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObject.Entity;

namespace ClassAndObject.Repository
{
    public class EventRepository
    {
        private List<Event> events = new List<Event>();
        public List<Event> Events { get {  return events; } }

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public decimal CalculateTotalRevenue()
        {
            decimal totalRevenue = 0;
            foreach (var ev in events)
            {
                totalRevenue += (ev.TotalSeats - ev.AvailableSeats) * ev.TicketPrice;
            }
            return totalRevenue;
        }

        public int GetBookedNoOfTickets()
        {
            int bookedTickets = 0;
            foreach (var ev in events)
            {
                bookedTickets += ev.TotalSeats - ev.AvailableSeats;
            }
            return bookedTickets;
        }

        public void BookTickets(Event ev, int numTickets)
        {
            if (ev.AvailableSeats >= numTickets)
            {
                ev.AvailableSeats -= numTickets;
                Console.WriteLine($"{numTickets} tickets booked for the event: {ev}");
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking.");
            }
        }

        public void CancelBooking(Event ev, int numTickets)
        {
            ev.AvailableSeats += numTickets;
            Console.WriteLine($"{numTickets} tickets canceled for the event: {ev}");
        }
    }
}
