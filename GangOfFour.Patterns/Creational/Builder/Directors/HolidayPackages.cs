using GangOfFour.Patterns.Creational.Builder.Builders;
using GangOfFour.Patterns.Creational.Builder.Stuff;
using System;

namespace GangOfFour.Patterns.Creational.Builder.Directors
{
    public class HolidayPackages
    {
        public void BuildStandardHolidayPackage(IHolidayBuilder scheduleBuilder)
        {
            var outboundDate = new DateTime(2021, 12, 30, 9, 00, 00);

            scheduleBuilder.AddFlights(new FlighInfo
            {
                Outbound = outboundDate,
                Inbound = outboundDate.AddDays(7),
                People = 2,
                Price = 95.50m
            });

            scheduleBuilder.AddHotel(new HotelReservation
            {
                Checkin = outboundDate.AddHours(3),
                Checkout = outboundDate.AddDays(7).AddHours(3),
                Price = 184.50m
            });
        }

        public void BuildVipHolidayPackage(IHolidayBuilder scheduleBuilder)
        {
            var outboundDate = new DateTime(2021, 12, 30, 9, 00, 00);

            scheduleBuilder.AddFlights(new FlighInfo
            {
                Outbound = outboundDate,
                Inbound = outboundDate.AddDays(7),
                People = 2,
                Price = 95.50m
            });

            scheduleBuilder.AddHotel(new HotelReservation
            {
                Checkin = outboundDate.AddHours(3),
                Checkout = outboundDate.AddDays(7).AddHours(3),
                Price = 184.50m
            });

            scheduleBuilder.AddThemePark(new ThemeParkTicket
            {
                Date = outboundDate.AddHours(5),
                Price = 50.00m,
                People = 2
            });

            scheduleBuilder.AddLuxuryDinner(new RestaurantReservation
            {
                Date = outboundDate.AddHours(10),
                Price = 120.00m,
                People = 2
            });

            scheduleBuilder.AddNightClubVipBox(new ClubReservation
            {
                Date = outboundDate.AddHours(13),
                Price = 395m
            });
        }
    }
}
