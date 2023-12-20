using System;
using Inheritance.Constants;
namespace Inheritance.Entity
{
    public class Movie : Event
    {
        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private string actorName;
        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        private string actressName;
        public string ActressName
        {
            get { return actressName; }
            set { actressName = value; }
        }

        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string genre, string actorName, string actressName)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType)
        {
            Genre = genre;
            ActorName = actorName;
            ActressName = actressName;
        }

        public void DisplayMovieDetails()
        {
            DisplayEventDetails();
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Actor: {ActorName}");
            Console.WriteLine($"Actress: {ActressName}");
        }
    }
}
