using GangOfFour.Patterns.Behavioral.Iterator.Iterators;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public abstract class AbstractAggregate
    {
        public abstract IIterator GetIterator();
    }
}
