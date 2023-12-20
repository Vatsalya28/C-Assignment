using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Constant;
namespace Abstraction.Entity
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
            
        {
            SportName = sportName;
            TeamsName = teamsName;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine("Sports Details:");
           DisplayEventDetails();
            Console.WriteLine($"Sport Name: {SportName}");
            Console.WriteLine($"Teams: {TeamsName}");
        }
    }

}