using GangOfFour.Patterns.Behavioral.Iterator.Aggregates;

namespace GangOfFour.Patterns.Behavioral.Iterator.Iterators
{
    public interface IIterator
    {
        Player Next();

        bool IsThereMore();
    }
}
