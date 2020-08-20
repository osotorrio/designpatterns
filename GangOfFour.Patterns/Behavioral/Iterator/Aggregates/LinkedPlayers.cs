using GangOfFour.Patterns.Behavioral.Iterator.Iterators;
using System.Collections.Generic;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public class LinkedPlayers : AbstractAggregate
    {
        private LinkedList<Player> _list = new LinkedList<Player>();

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

                for (int i = 1; i < 2; i++)
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
