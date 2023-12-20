using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Entity
{
    public class Booking
    {
        private Event eventInstance;
        private int totalTicketsBooked;
        private decimal totalBookingCost;

        public Booking(Event eventInstance)
        {
            this.eventInstance = eventInstance;
            totalTicketsBooked = 0;
            totalBookingCost = 0;
        }
        public void CalculateBookingCost(int numTickets)
        {
            totalTicketsBooked = numTickets;
            totalBookingCost = eventInstance.TicketPrice * numTickets;
        }

        public void BookTickets(int numTickets)
        {
            if (eventInstance.AvailableSeats >= numTickets)
            {
                eventInstance.AvailableSeats -= numTickets;
                CalculateBookingCost(numTickets);
                Console.WriteLine($"{numTickets} tickets booked successfully!");
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking.");
            }
        }

        public void CancelBooking()
        {
            eventInstance.AvailableSeats += totalTicketsBooked;
            totalTicketsBooked = 0;
            totalBookingCost = 0;
            Console.WriteLine("Booking canceled successfully!");
        }

        public int GetAvailableNoOfTickets()
        {
            return eventInstance.AvailableSeats;
        }

        public string GetEventDetails()
        {
            return eventInstance.ToString();
        }
    }
}
