using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Products
{
    public class PriceSummary
    {
        public PriceSummary(FlighInfo flight, HotelReservation hotel, TouristBusTicket bus, ThemeParkTicket park, RestaurantReservation restaurant, ClubReservation club)
        {
            Flight = flight;
            Hotel = hotel;
            Bus = bus;
            Park = park;
            Restaurant = restaurant;
            Club = club;
        }

        public FlighInfo Flight { get; }

        public HotelReservation Hotel { get; }

        public TouristBusTicket Bus { get; }

        public ThemeParkTicket Park { get; }

        public RestaurantReservation Restaurant { get; }

        public ClubReservation Club { get; }

        public decimal CalculateTotalPrice()
        {
            return (Flight.Price * Flight.People)
                    +
                    (Hotel.Price * (Hotel.Checkout - Hotel.Checkin).Days)
                    +
                    (Bus.Price * Bus.People)
                    +
                    (Park.Price * Park.People)
                    +
                    (Restaurant.Price * Restaurant.People)
                    +
                    (Club.Price);
        }
    }
}