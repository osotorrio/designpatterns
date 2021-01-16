using System;
using System.Text;
using GangOfFour.Patterns.Creational.Builder.Stuff;

namespace GangOfFour.Patterns.Creational.Builder.Products
{
    public class ScheduleSummary
    {
        public ScheduleSummary(DateTime outboundFlight, DateTime inboundFlight, DateTime checkinHotel, DateTime checkoutHotel, DateTime busDate, DateTime themeParkDate, DateTime dinningDate, DateTime nightoutDate)
        {
            OutboundFlightDate = outboundFlight;
            InboundFlightDate = inboundFlight;
            CheckinHotelDate = checkinHotel;
            CheckoutHotelDate = checkoutHotel;
            TouristBusDate = busDate;
            ThemeParkDate = themeParkDate;
            DinningDate = dinningDate;
            NightoutDate = nightoutDate;
        }

        public DateTime OutboundFlightDate { get; }

        public DateTime InboundFlightDate { get; }

        public DateTime CheckinHotelDate { get; }

        public DateTime CheckoutHotelDate { get; }

        public DateTime TouristBusDate { get; }

        public DateTime ThemeParkDate { get; }

        public DateTime DinningDate { get; }

        public DateTime NightoutDate { get; }

        public string PrintoutSchedule()
        {
            var schedule = new StringBuilder();

            if (OutboundFlightDate != null && InboundFlightDate != null)
                schedule.AppendLine($"Holidays from {OutboundFlightDate} to {InboundFlightDate}");

            if (CheckinHotelDate != null && CheckoutHotelDate != null)
                schedule.AppendLine($"Staying in hotel from {CheckinHotelDate} to {CheckoutHotelDate}");

            if (TouristBusDate != null)
                schedule.AppendLine($"Taking the tourist bus on the date {TouristBusDate}");

            if (ThemeParkDate != null)
                schedule.AppendLine($"Fun in the theme park on the date {ThemeParkDate}");

            if (DinningDate != null)
                schedule.AppendLine($"Having dinner on the date {DinningDate}");

            if (NightoutDate != null)
                schedule.AppendLine($"Party out all night on the date {NightoutDate}");

            return schedule.ToString();
        }
    }
}