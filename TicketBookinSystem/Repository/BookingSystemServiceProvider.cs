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
    public class BookingSystemServiceProvider:IBookingSystemServiceProvider
    {
        public string connectionString;
        SqlCommand cmd = null;

        public BookingSystemServiceProvider()
        {
            connectionString = DbConnUtil.GetConnectionString();
            cmd = new SqlCommand();
        }

        public List<Booking> BookingDetails()
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "SELECT * FROM Booking";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Booking booking = new Booking();
                        booking.booking_id = (int)reader["booking_id"];
                        booking.customer_id = (int)reader["customer_id"];
                        booking.event_id = (int)reader["event_id"];
                        booking.total_cost = (decimal)reader["total_cost"];
                        booking.booking_date = (DateTime)reader["booking_date"];
                        bookings.Add(booking);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return bookings;
        }



        public void CancelBooking(int bookingId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Retrieve booking details
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Booking WHERE booking_id = @BookingId", sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@BookingId", bookingId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int eventId = (int)reader["event_id"];
                                int customerId = (int)reader["customer_id"];
                                reader.Close();

                                // Update available seats in the corresponding event
                                UpdateAvailableSeats(eventId, 1, sqlConnection); // Pass the connection as a parameter

                                // Delete the booking record
                                using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Booking WHERE booking_id = @BookingId", sqlConnection))
                                {
                                    deleteCmd.Parameters.AddWithValue("@BookingId", bookingId);
                                    deleteCmd.ExecuteNonQuery();

                                    Console.WriteLine($"Booking {bookingId} canceled successfully.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Booking with ID {bookingId} not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateAvailableSeats(int eventId, int seatsChange, SqlConnection sqlConnection)
        {
            try
            {
                // Update available seats in the corresponding event
                using (SqlCommand cmd = new SqlCommand("UPDATE Event SET available_seats = available_seats + @SeatsChange WHERE event_id = @EventId", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@SeatsChange", seatsChange);
                    cmd.Parameters.AddWithValue("@EventId", eventId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}
