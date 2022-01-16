using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;

namespace GangOfFour.Patterns.Behavioral.Iterator.Iterators
{
    public class LinkedPlayersIterator : IIterator
    {
        private readonly LinkedPlayers _collection;
        private int _counter = 0;

        public LinkedPlayersIterator(LinkedPlayers collection)
        {
            _collection = collection;
        }

        public bool IsThereMore()
        {
            return _counter < _collection.Count;
        }

        public Player Next()
        {
            return _collection[_counter++];
        }
    }
}
