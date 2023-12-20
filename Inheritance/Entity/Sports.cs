using Inheritance.Constants;

namespace Inheritance.Entity
{
    public class Sports : Event
    {
        private string sportName;
        public string SportName
        {
            get { return sportName; }
            set { sportName = value; }
        }

        private string teamsName;
        public string TeamsName
        {
            get { return teamsName; }
            set { teamsName = value; }
        }

        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string sportName, string teamsName)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType)
        {
            SportName = sportName;
            TeamsName = teamsName;
        }

        public void DisplaySportDetails()
        {
            DisplayEventDetails();
            Console.WriteLine($"Sport Name: {SportName}");
            Console.WriteLine($"Teams: {TeamsName}");
        }
    }
}
