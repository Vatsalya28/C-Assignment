Console.Write("Enter the total number of available tickets: ");
int availableTicket = int.Parse(Console.ReadLine());

Console.Write("Enter the number of tickets to book: ");
int noOfBookingTicket = int.Parse(Console.ReadLine());

if (noOfBookingTicket > 0 && noOfBookingTicket <= availableTicket)
{
    int remainingTickets = availableTicket - noOfBookingTicket;
    Console.WriteLine($"Tickets booked successfully! Remaining tickets: {remainingTickets}");
}
else if (noOfBookingTicket > availableTicket)
{
    
    Console.WriteLine("Ticket unavailable. Not enough tickets available.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number of tickets to book.");
}