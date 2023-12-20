using Abstraction.Entity;
using Abstraction.Constant;



TicketBookingSystem ticketBookingSystem = new TicketBookingSystem();

while (true)
{
    Console.WriteLine("Enter a command (create_event, display_event_details, book_tickets, cancel_tickets, get_available_seats, exit):");
    string command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "create_event":
            Console.WriteLine("Enter event details:");
            Console.Write("Event Name: ");
            string eventName = Console.ReadLine();
            Console.Write("Date (yyyy-mm-dd): ");
            string date = Console.ReadLine();
            Console.Write("Time (hh:mm): ");
            string time = Console.ReadLine();
            Console.Write("Total Seats: ");
            int totalSeats = int.Parse(Console.ReadLine());
            Console.Write("Ticket Price: ");
            decimal ticketPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Event Type (movie, concert, sports): ");
            string eventType = Console.ReadLine();
            Console.Write("Venue Name: ");
            string venueName = Console.ReadLine();

            Event newEvent = ticketBookingSystem.CreateEvent(eventName, date, time, totalSeats, ticketPrice, eventType, venueName);
            Console.WriteLine($"Event '{newEvent.EventName}' created.");
            break;

        case "display_event_details":
            Console.WriteLine("Enter the event name:");
            string eventToDisplay = Console.ReadLine();
            Event eventObj = ticketBookingSystem.events.Find(e => e.EventName.Equals(eventToDisplay, StringComparison.OrdinalIgnoreCase));
            if (eventObj != null)
            {
                ticketBookingSystem.DisplayEventDetails(eventObj);
            }
            else
            {
                Console.WriteLine($"Event '{eventToDisplay}' not found.");
            }
            break;

        case "book_tickets":
            Console.WriteLine("Enter the event name:");
            string eventToBook = Console.ReadLine();
            Event eventToBookObj = ticketBookingSystem.events.Find(e => e.EventName.Equals(eventToBook, StringComparison.OrdinalIgnoreCase));
            if (eventToBookObj != null)
            {
                Console.Write("Enter the number of tickets to book: ");
                int numTicketsToBook = int.Parse(Console.ReadLine());
                decimal totalCost = ticketBookingSystem.BookTickets(eventToBookObj, numTicketsToBook);
                Console.WriteLine($"Total cost: {totalCost:C}");
            }
            else
            {
                Console.WriteLine($"Event '{eventToBook}' not found.");
            }
            break;

        case "cancel_tickets":
            Console.WriteLine("Enter the event name:");
            string eventToCancel = Console.ReadLine();
            Event eventToCancelObj = ticketBookingSystem.events.Find(e => e.EventName.Equals(eventToCancel, StringComparison.OrdinalIgnoreCase));
            if (eventToCancelObj != null)
            {
                Console.Write("Enter the number of tickets to cancel: ");
                int numTicketsToCancel = int.Parse(Console.ReadLine());
                ticketBookingSystem.CancelTickets(eventToCancelObj, numTicketsToCancel);
            }
            else
            {
                Console.WriteLine($"Event '{eventToCancel}' not found.");
            }
            break;

        case "get_available_seats":
            Console.WriteLine("Enter the event name:");
            string eventToCheckSeats = Console.ReadLine();
            Event eventToCheckSeatsObj = ticketBookingSystem.events.Find(e => e.EventName.Equals(eventToCheckSeats, StringComparison.OrdinalIgnoreCase));
            if (eventToCheckSeatsObj != null)
            {
                int availableSeats = eventToCheckSeatsObj.AvailableSeats;
                Console.WriteLine($"Available seats for '{eventToCheckSeats}': {availableSeats}");
            }
            else
            {
                Console.WriteLine($"Event '{eventToCheckSeats}' not found.");
            }
            break;

        case "exit":
            Console.WriteLine("Exiting the program.");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid command. Please enter a valid command.");
            break;
    }
}