using GangOfFour.Patterns.Behavioral.Iterator.Iterators;
using System.Collections;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class ArrayPlayers : AbstractAggregate
    {
        private ArrayList _list = new ArrayList();

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
