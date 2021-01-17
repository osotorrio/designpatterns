using GangOfFour.Patterns.Creational.Builder.Products;
using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    /// <summary>
    /// Builder
    /// </summary>
    public class PriceSummaryBuilder : IHolidayBuilder
    {
        private FlightReservation _flight;

        private HotelReservation _hotel;

        private RestaurantReservation _restaurant;

        private ClubReservation _club;

        private ThemeParkReservation _park;

        public void Reset()
        {
            _flight = null;
            _hotel = null;
            _restaurant = null;
            _club = null;
            _park = null;
        }

        public void AddFlights(FlightReservation flightInfo)
        {
            _flight = flightInfo;
        }

        public void AddHotel(HotelReservation hotelReservation)
        {
            _hotel = hotelReservation;
        }

        public void AddLuxuryDinner(RestaurantReservation restaurantReservation)
        {
            _restaurant = restaurantReservation;
        }

        public void AddNightClubVipBox(ClubReservation clubReservation)
        {
            _club = clubReservation;
        }

        public void AddThemePark(ThemeParkReservation themeParkTicket)
        {
            _park = themeParkTicket;
        }

        public PriceSummary Build()
        {
            return new PriceSummary(_flight, _hotel, _park, _restaurant, _club);
        }
    }
}
