using GangOfFour.Patterns.Creational.Builder.Stuff;
using System.Text;

namespace GangOfFour.Patterns.Creational.Builder.Products
{
    /// <summary>
    /// Product
    /// </summary>
    public class ScheduleSummary
    {
        public ScheduleSummary(FlightReservation flight, HotelReservation hotel, ThemeParkReservation park, RestaurantReservation restaurant, ClubReservation club)
        {
            Flight = flight;
            Hotel = hotel;
            Park = park;
            Restaurant = restaurant;
            Club = club;
        }

        public FlightReservation Flight { get; }

        public HotelReservation Hotel { get; }

        public ThemeParkReservation Park { get; }

        public RestaurantReservation Restaurant { get; }

        public ClubReservation Club { get; }

        public string PrintoutSchedule()
        {
            var schedule = new StringBuilder();

            if (Flight != null)
                schedule.AppendLine($"Flying from {Flight.Outbound} to {Flight.Inbound}");

            if (Hotel != null)
                schedule.AppendLine($"Hotel from {Hotel.Checkin} to {Hotel.Checkout}");

            if (Park != null)
                schedule.AppendLine($"Theme park on the date {Park.Date}");

            if (Restaurant != null)
                schedule.AppendLine($"Dinner on the date {Restaurant.Date}");

            if (Club != null)
                schedule.AppendLine($"Party out on the date {Club.Date}");

            return schedule.ToString();
        }
    }
}
