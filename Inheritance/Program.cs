using Inheritance.Entity;
using Inheritance.Constants;


TicketBookingSystem ticketBookingSystem = new TicketBookingSystem();

Event movieEvent = ticketBookingSystem.CreateEvent("Avengers: Endgame", "2023-12-31", "18:00:00", 100, 15, "Movie", "Cinema Hall");
Event sportsEvent = ticketBookingSystem.CreateEvent("Football Match", "2023-12-25", "15:30:00", 200, 20, "Sports", "Stadium");
Event concertEvent = ticketBookingSystem.CreateEvent("Live Concert", "2023-12-20", "20:00:00", 150, 25, "Concert", "Arena");

ticketBookingSystem.DisplayEventDetails(movieEvent);
ticketBookingSystem.DisplayEventDetails(sportsEvent);
ticketBookingSystem.DisplayEventDetails(concertEvent);

Console.WriteLine("\nBooking Tickets:");
float bookingCost = ticketBookingSystem.BookTickets(movieEvent, 2);
Console.WriteLine($"Booking Cost: {bookingCost}");

Console.WriteLine("\nUpdated Event Details:");
ticketBookingSystem.DisplayEventDetails(movieEvent);

Console.WriteLine("\nCanceling Tickets:");
ticketBookingSystem.CancelTickets(movieEvent, 1);

Console.WriteLine("\nUpdated Event Details after Cancellation:");
ticketBookingSystem.DisplayEventDetails(movieEvent);