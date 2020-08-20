using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;
using System;

namespace GangOfFour.Patterns.Behavioral.Iterator.Iterators
{
    public class ArrayPlayersIterator : IIterator
    {
        private ArrayPlayers _collection;
        private int _counter = 0;

        public ArrayPlayersIterator(ArrayPlayers collection)
        {
            _collection = collection;
        }

        public bool IsThereMore()
        {
            return _collection.Count < _counter;
        }

        public Player Next()
        {
            return _collection[++_counter];
        }
    }
}
