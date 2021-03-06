using System;

namespace GangOfFour.Patterns.Creational.Builder.Stuff
{
    public class FlightReservation
    {
        public DateTime Outbound { get; set; }
        public DateTime Inbound { get; set; }
        public int People { get; set; }
        public decimal Price { get; set; }
    }
}