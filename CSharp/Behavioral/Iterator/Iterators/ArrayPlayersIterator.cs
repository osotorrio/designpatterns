using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;

namespace GangOfFour.Patterns.Behavioral.Iterator.Iterators
{
    public class ArrayPlayersIterator : IIterator
    {
        private readonly ArrayPlayers _collection;
        private int _counter = 0;

        public ArrayPlayersIterator(ArrayPlayers collection)
        {
            _collection = collection;
        }

        public bool IsThereMore()
        {
            return _collection.Count > _counter;
        }

        public Player Next()
        {
            return _collection[_counter++];
        }
    }
}
