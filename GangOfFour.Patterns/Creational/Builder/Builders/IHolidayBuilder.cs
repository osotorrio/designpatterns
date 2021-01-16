using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Builders
{
    /// <summary>
    /// Builder
    /// </summary>
    public interface IHolidayBuilder
    {
        public void AddFlights(FlighInfo flightInfo);

        public void AddHotel(HotelReservation hotelReservation);

        public void AddThemePark(ThemeParkTicket ThemeParkTicket);

        public void AddLuxuryDinner(RestaurantReservation restaurantReservation);

        public void AddNightClubVipBox(ClubReservation clubReservation);
    }
}
