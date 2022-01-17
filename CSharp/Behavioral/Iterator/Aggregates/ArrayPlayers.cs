using System.Collections;
using GangOfFour.Patterns.Behavioral.Iterator.Iterators;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class ArrayPlayers : AbstractAggregate
    {
        private readonly ArrayList _list = new();

        public override IIterator GetIterator()
        {
            return new ArrayPlayersIterator(this);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public Player this[int index]
        {
            get { return _list[index] as Player; }
            set { _list.Add(value); }
        }
    }
}
