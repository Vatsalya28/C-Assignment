using Inheritance.Constants;

namespace Inheritance.Entity
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

        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string artist, string concertType)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType)
        {
            Artist = artist;
            ConcertType = concertType;
        }

        public void DisplayConcertDetails()
        {
            DisplayEventDetails();
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Concert Type: {ConcertType}");
        }
    }
}
