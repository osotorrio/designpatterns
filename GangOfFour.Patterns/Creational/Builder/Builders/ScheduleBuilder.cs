using System;
using GangOfFour.Patterns.Creational.Builder.Products;
using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    public class ScheduleBuilder : IHolidayBuilder
    {
        private FlighInfo _flight;

        private HotelReservation _hotel;

        private RestaurantReservation _restaurant;

        private ClubReservation _club;

        private ThemeParkTicket _park;

        private TouristBusTicket _bus;

        public void AddFlights(FlighInfo flightInfo)
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

        public void AddThemePark(ThemeParkTicket themeParkTicket)
        {
            _park = themeParkTicket;
        }

        public void AddTouristBus(TouristBusTicket bustTicket)
        {
            _bus = bustTicket;
        }

        public ScheduleSummary Build()
        {
            return new ScheduleSummary(
                _flight.Outbound,
                _flight.Inbound,
                _hotel.Checkin,
                _hotel.Checkout,
                _bus.Date,
                _park.Date,
                _restaurant.Date,
                _club.Date);
        }
    }
}