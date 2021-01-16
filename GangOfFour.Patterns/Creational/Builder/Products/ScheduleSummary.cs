using GangOfFour.Patterns.Creational.Builder.Stuff;
using System.Text;

namespace GangOfFour.Patterns.Creational.Builder.Products
{
    public class ScheduleSummary
    {
        public ScheduleSummary(FlighInfo flight, HotelReservation hotel, ThemeParkTicket park, RestaurantReservation restaurant, ClubReservation club)
        {
            Flight = flight;
            Hotel = hotel;
            Park = park;
            Restaurant = restaurant;
            Club = club;
        }

        public FlighInfo Flight { get; }

        public HotelReservation Hotel { get; }

        public ThemeParkTicket Park { get; }

        public RestaurantReservation Restaurant { get; }

        public ClubReservation Club { get; }

        public string PrintoutSchedule()
        {
            var schedule = new StringBuilder();

            if (Flight != null)
                schedule.AppendLine($"Holidays from {Flight.Outbound} to {Flight.Inbound}");

            if (Hotel != null)
                schedule.AppendLine($"Staying in hotel from {Hotel.Checkin} to {Hotel.Checkout}");

            if (Park != null)
                schedule.AppendLine($"Fun in the theme park on the date {Park.Date}");

            if (Restaurant != null)
                schedule.AppendLine($"Having dinner on the date {Restaurant.Date}");

            if (Club != null)
                schedule.AppendLine($"Party out all night on the date {Club.Date}");

            return schedule.ToString();
        }
    }
}
