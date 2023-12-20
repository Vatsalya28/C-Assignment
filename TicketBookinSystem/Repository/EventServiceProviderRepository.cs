using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookinSystem.Entity;
using TicketBookinSystem.Utility;

using Microsoft.Data.SqlClient;

namespace TicketBookinSystem.Repository
{
    public class EventServiceProviderRepository : IEventServiceProviderRepository
    {
        public string connectionString;
        SqlCommand cmd = null;

        public EventServiceProviderRepository()
        {
            connectionString = DbConnUtil.GetConnectionString();
            cmd = new SqlCommand();
        }

        public List<Event> GetEventDetails()
        {
            List<Event> events = new List<Event>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "SELECT * FROM Event";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Event eventItem = new Event();
                        eventItem.event_id = (int)reader["event_id"];
                        eventItem.event_name = (string)reader["event_name"];
                        eventItem.event_date = (DateTime)reader["event_date"];
                        eventItem.event_time = (TimeSpan)reader["event_time"];
                        eventItem.venue_id = (int)reader["venue_id"];
                        eventItem.total_seats = (int)reader["total_seats"];
                        eventItem.available_seats = (int)reader["available_seats"];
                        eventItem.ticket_price = (decimal)reader["ticket_price"];
                        // Assuming event_type is a string in the database
                        eventItem.event_type = Enum.Parse<EventType>((string)reader["event_type"]);
                        eventItem.booking_id = (int)reader["booking_id"];

                        events.Add(eventItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return events;
        }


        public int GetAvailableNoOfTickets(int eventId)
        {
            int availableTickets = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "SELECT available_seats FROM Event WHERE event_id = @EventId";
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@EventId", eventId);

                    sqlConnection.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        availableTickets = (int)result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return availableTickets;
        }

        public Event CreateEvent(int eventID,string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, Venue venue)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "INSERT INTO Event (event_id,event_name, event_date, event_time, venue_id, total_seats, available_seats, ticket_price, event_type) " +
                                      "OUTPUT INSERTED.event_id " +
                                      "VALUES (@EventID,@EventName, @EventDate, @EventTime, @VenueId, @TotalSeats, @TotalSeats, @TicketPrice, @EventType)";
                    cmd.Connection = sqlConnection;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@EventID", eventID);
                    cmd.Parameters.AddWithValue("@EventName", eventName);
                    cmd.Parameters.AddWithValue("@EventDate", DateTime.Parse(date));
                    cmd.Parameters.AddWithValue("@EventTime", TimeSpan.Parse(time));
                    cmd.Parameters.AddWithValue("@VenueId", venue.venue_id);
                    cmd.Parameters.AddWithValue("@TotalSeats", totalSeats);
                    cmd.Parameters.AddWithValue("@TicketPrice", ticketPrice);
                    cmd.Parameters.AddWithValue("@EventType", eventType);

                    sqlConnection.Open();

                    // Execute the query and get the newly inserted event_id
                    int eventId = (int)cmd.ExecuteScalar();

                    // Create and return the Event object
                    return new Event
                    {
                        event_id = eventID,
                        event_name = eventName,
                        event_date = DateTime.Parse(date),
                        event_time = TimeSpan.Parse(time),
                        venue_id = venue.venue_id,
                        total_seats = totalSeats,
                        available_seats = totalSeats, // Initially all seats are available
                        ticket_price = ticketPrice,
                        event_type = Enum.Parse<EventType>(eventType),
                        booking_id = 0 // Set to 0 or appropriate default value
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Return null in case of an error
            }
        }

    }
}








