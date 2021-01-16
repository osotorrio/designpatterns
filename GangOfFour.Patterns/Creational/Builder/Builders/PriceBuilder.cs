﻿using GangOfFour.Patterns.Creational.Builder.Products;
using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    public class PriceBuilder : IHolidayBuilder
    {
        private FlighInfo _flight;

        private HotelReservation _hotel;

        private RestaurantReservation _restaurant;

        private ClubReservation _club;

        private ThemeParkTicket _park;

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

        public PriceSummary Build()
        {
            return new PriceSummary(_flight, _hotel, _park, _restaurant, _club);
        }
    }
}
