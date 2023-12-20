using System;
using Abstraction.Constant;

namespace Abstraction.Entity
{
    public class Concert : Event
    {
        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private string concertType;
        public string ConcertType
        {
            get { return concertType; }
            set { concertType = value; }
        }

        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, int availableSeats, decimal ticketPrice, string artist, string concertType)
            
        {
            Artist = artist;
            ConcertType = concertType;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine("Concert Details:");
            DisplayEventDetails();
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Concert Type: {ConcertType}");
        }
    }
}
