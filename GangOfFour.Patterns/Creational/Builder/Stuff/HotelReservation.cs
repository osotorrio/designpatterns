using System;

namespace GangOfFour.Patterns.Creational.Builder.Stuff
{
    public class HotelReservation
    {
        public DateTime Checkin { get; internal set; }
        public DateTime Checkout { get; internal set; }
        public int Price { get; internal set; }
    }
}