using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    public interface IHolidayBuilder
    {
        public void AddFlights(FlighInfo flightInfo);

        public void AddHotel(HotelReservation hotelReservation);

        public void AddThemePark(ThemeParkTicket ThemeParkTicket);

        public void AddTouristBus(TouristBusTicket bustTicket);

        public void AddLuxuryDinner(RestaurantReservation restaurantReservation);

        public void AddNightClubVipBox(ClubReservation clubReservation);
    }
}