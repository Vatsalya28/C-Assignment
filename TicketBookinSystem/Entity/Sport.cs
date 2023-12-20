using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookinSystem.Entity
{
    public class Sports : Event
    {
        
        public string SportName { get; set; }
        public string TeamsName { get; set; }

      
        public Sports()
        {
            event_type = EventType.Sport;
        }

        
        public Sports(int customerId, string customerName, string sportName, string teamsName)
        {
          
            SportName = sportName;
            TeamsName = teamsName;

            event_type = EventType.Sport;
        }

       
        public void display_sport_details()
        {
            Console.WriteLine($"Sport Details:\nSport: {SportName}\nTeams: {TeamsName}\n{base.ToString()}");
        }
    }
}
