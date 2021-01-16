using System;

namespace GangOfFour.Patterns.Creational.Builder.Stuff
{
    public class FlighInfo
    {
        public DateTime Outbound { get; internal set; }
        public DateTime Inbound { get; internal set; }
        public int People { get; internal set; }
        public int Price { get; internal set; }
    }
}