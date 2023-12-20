using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookinSystem.Entity;

namespace TicketBookinSystem.Repository
{
    public interface IBookingSystemServiceProvider
    {
        public List<Booking> BookingDetails();
        public void CancelBooking(int bookingId);
    }
}
