using TicketBookinSystem.Entity;
using TicketBookinSystem.Repository;

IEventServiceProviderRepository repository =new EventServiceProviderRepository();
IBookingSystemServiceProvider bookingRepository = new BookingSystemServiceProvider();

#region EventDetails
//var events = repository.GetEventDetails();

//Console.WriteLine("Event Details:");
//foreach (var ev in events)
//{
//    Console.WriteLine(ev.ToString());
//}
#endregion


#region Available seats

//Console.Write("Enter Event ID: ");
//if (int.TryParse(Console.ReadLine(), out int eventId))
//{
//    // Get the available tickets for the specified event
//    int availableTickets = repository.GetAvailableNoOfTickets(eventId);

//    Console.WriteLine($"Available Tickets for Event {eventId}: {availableTickets}");
//}
//else
//{
//    Console.WriteLine("Invalid Event ID. Please enter a valid integer.");
//}




#endregion region


#region Create Event
//Console.Write("Enter Venue ID: ");
//if (int.TryParse(Console.ReadLine(), out int venueId))
//{
//    Console.Write("Enter Venue Name: ");
//    string venueName = Console.ReadLine();

//    // Create a new Venue object with user input
//    Venue venue = new Venue
//    {
//        venue_id = venueId,
//        venue_name = venueName
//        // Add other venue properties as needed
//    };

//    // Take input for new event details from the user
//    Console.WriteLine("Enter Event Id:");
//    int eventID = int.Parse(Console.ReadLine());
//    Console.Write("Enter Event Name: ");
//    string eventName = Console.ReadLine();

//    Console.Write("Enter Date (YYYY-MM-DD): ");
//    string date = Console.ReadLine();

//    Console.Write("Enter Time (HH:mm:ss): ");
//    string time = Console.ReadLine();

//    Console.Write("Enter Total Seats: ");
//    if (int.TryParse(Console.ReadLine(), out int totalSeats))
//    {
//        Console.Write("Enter Ticket Price: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal ticketPrice))
//        {
//            Console.Write("Enter Event Type (Movie, Sports, Concert): ");
//            string eventType = Console.ReadLine();

//            // Create a new event using the repository
//            Event newEvent = repository.CreateEvent(eventID , eventName, date, time, totalSeats, ticketPrice, eventType, venue);

//            // Check if the event was created successfully
//            if (newEvent != null)
//            {
//                Console.WriteLine($"Event created successfully! Event ID: {newEvent.event_id}");
//            }
//            else
//            {
//                Console.WriteLine("Failed to create the event.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid Ticket Price. Please enter a valid decimal.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid Total Seats. Please enter a valid integer.");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid Venue ID. Please enter a valid integer.");
//}




#endregion


#region get booking details
//var bookings = bookingRepository.BookingDetails();

//Console.WriteLine("Event Details:");
//foreach (var book in bookings)
//{
//    Console.WriteLine(book.ToString());
//}


#endregion

#region Cancel Booking
//Console.Write("Enter Booking ID to cancel: ");
//if (int.TryParse(Console.ReadLine(), out int bookingId))
//{
//    bookingRepository.CancelBooking(bookingId);
//}
//else
//{
//    Console.WriteLine("Invalid Booking ID. Please enter a valid integer.");
//}
            



#endregion