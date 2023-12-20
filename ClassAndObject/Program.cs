using System;
using ClassAndObject.Entity;
using ClassAndObject.Constant;


Event movieEvent = new Event("Movie Night", DateTime.Now.AddDays(7), new TimeSpan(19, 0, 0), "Cinema Hall", 100, 100, 10.0m, EventType.Movie);
Booking booking = new Booking(movieEvent);

Console.WriteLine("Event Details:");
Console.WriteLine(movieEvent.ToString());

Console.WriteLine("Choose an option:");
Console.WriteLine("1. Book Tickets");
Console.WriteLine("2. Cancel Booking");

Console.Write("Enter your choice (1 or 2): ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.Write("Enter the number of tickets to book: ");
        int numTicketsToBook = Convert.ToInt32(Console.ReadLine());
        booking.BookTickets(numTicketsToBook);

        Console.WriteLine("\nUpdated Event Details:");
        Console.WriteLine(booking.GetEventDetails());

        int availableTickets = booking.GetAvailableNoOfTickets();
        Console.WriteLine($"Available Tickets: {availableTickets}");
        break;

    case 2:
        booking.CancelBooking();
        Console.WriteLine("\nUpdated Event Details after Cancellation:");
        Console.WriteLine(booking.GetEventDetails());
        break;

    default:
        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        break;

}