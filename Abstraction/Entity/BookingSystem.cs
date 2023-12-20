using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entity
{
    public abstract class BookingSystem
    {
        public abstract Event CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, string venueName);

        public abstract void DisplayEventDetails(Event eventObj);

        public abstract decimal BookTickets(Event eventObj, int numTickets);

        public abstract void CancelTickets(Event eventObj, int numTickets);
    }
}
