using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    /// <summary>
    /// Builder
    /// </summary>
    public interface IHolidayBuilder
    {
        public void Reset();

        public void AddFlights(FlightReservation flightInfo);

        public void AddHotel(HotelReservation hotelReservation);

        public void AddThemePark(ThemeParkReservation ThemeParkTicket);

        public void AddLuxuryDinner(RestaurantReservation restaurantReservation);

        public void AddNightClubVipBox(ClubReservation clubReservation);
    }
}
