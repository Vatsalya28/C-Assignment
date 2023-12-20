Console.WriteLine("Ticket Categories:");
Console.WriteLine("1. Silver");
Console.WriteLine("2. Gold");
Console.WriteLine("3. Diamond");

Console.Write("Enter the number corresponding to the ticket category: ");
int ticketCategory = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of tickets needed: ");
int noOfTickets = Convert.ToInt32(Console.ReadLine());

double baseTicketPrice;

switch (ticketCategory)
{
    case 1:
        baseTicketPrice = 50; 
        break;
    case 2:
        baseTicketPrice = 100; 
        break;
    case 3:
        baseTicketPrice = 150; 
        break;
    default:
        Console.WriteLine("Invalid ticket category. Please select a valid option.");
        return;
}

double totalCost = baseTicketPrice * noOfTickets;

Console.WriteLine($"Tickets booked successfully! Total cost: {totalCost}");
    