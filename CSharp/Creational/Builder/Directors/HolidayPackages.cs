using System;
using GangOfFour.Patterns.Creational.Builder.Builders;
using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Directors
{
    /// <summary>
    /// Director
    /// </summary>
    public class HolidayPackages
    {
        public void ConfigureStandardHolidayPackage(IHolidayBuilder builder)
        {
            var outboundDate = new DateTime(2021, 12, 30, 9, 00, 00);

            builder.AddFlights(new FlightReservation
            {
                Outbound = outboundDate,
                Inbound = outboundDate.AddDays(7),
                People = 2,
                Price = 95.50m
            });

            builder.AddHotel(new HotelReservation
            {
                Checkin = outboundDate.AddHours(3),
                Checkout = outboundDate.AddDays(7).AddHours(3),
                Price = 184.50m
            });

            builder.AddThemePark(new ThemeParkReservation
            {
                Date = outboundDate.AddHours(5),
                Price = 50.00m,
                People = 2
            });
        }

        public void ConfigureVipHolidayPackage(IHolidayBuilder builder)
        {
            var outboundDate = new DateTime(2021, 12, 30, 9, 00, 00);

            builder.AddFlights(new FlightReservation
            {
                Outbound = outboundDate,
                Inbound = outboundDate.AddDays(7),
                People = 2,
                Price = 95.50m
            });

            builder.AddHotel(new HotelReservation
            {
                Checkin = outboundDate.AddHours(3),
                Checkout = outboundDate.AddDays(7).AddHours(3),
                Price = 184.50m
            });

            builder.AddLuxuryDinner(new RestaurantReservation
            {
                Date = outboundDate.AddHours(10),
                Price = 120.00m,
                People = 2
            });

            builder.AddNightClubVipBox(new ClubReservation
            {
                Date = outboundDate.AddHours(13),
                Price = 395m
            });
        }
    }
}
