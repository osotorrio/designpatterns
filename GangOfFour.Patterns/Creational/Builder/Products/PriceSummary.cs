using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Products
{
    /// <summary>
    /// Product
    /// </summary>
    public class PriceSummary
    {
        public PriceSummary(FlighInfo flight, HotelReservation hotel, ThemeParkTicket park, RestaurantReservation restaurant, ClubReservation club)
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

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;

            if (Flight != null)
                total += Flight.Price * Flight.People;

            if (Hotel != null)
                total += Hotel.Price * (Hotel.Checkout - Hotel.Checkin).Days;

            if (Park != null)
                total += Park.Price * Park.People;

            if (Restaurant != null)
                total += Restaurant.Price * Restaurant.People;

            if (Club != null)
                total += Club.Price;

            return total;
        }
    }
}
