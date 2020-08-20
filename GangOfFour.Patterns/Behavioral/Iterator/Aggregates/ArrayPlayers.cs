using GangOfFour.Patterns.Behavioral.Iterator.Iterators;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class ArrayPlayers : AbstractAggregate
    {
        private Player[] _list = new Player[10];

        public override IIterator GetIterator()
        {
            return new ArrayPlayersIterator(this);
        }

        public int Count
        {
            get { return _list.Length; }
        }

        public Player this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }
    }
}
