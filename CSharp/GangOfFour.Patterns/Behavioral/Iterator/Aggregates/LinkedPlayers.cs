using System.Collections.Generic;
using GangOfFour.Patterns.Behavioral.Iterator.Iterators;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class LinkedPlayers : AbstractAggregate
    {
        private readonly LinkedList<Player> _list = new();

        public override IIterator GetIterator()
        {
            return new LinkedPlayersIterator(this);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public Player this[int index]
        {
            get
            {
                var current = _list.First;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Value;
            }
            set
            {
                if (index == 0)
                {
                    _list.AddFirst(value);
                }
                else
                {
                    var current = _list.First;

                    for (int i = 1; i < index; i++)
                    {
                        current = current.Next;
                    }

                    _list.AddAfter(current, value);
                }
            }
        }
    }
}
