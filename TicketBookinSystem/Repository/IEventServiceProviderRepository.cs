using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookinSystem.Entity;

namespace TicketBookinSystem.Repository
{
    public interface IEventServiceProviderRepository
    {
        public List<Event> GetEventDetails();
        public int GetAvailableNoOfTickets(int eventId);
        public Event CreateEvent(int eventID,string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, Venue venue);


    }
}
