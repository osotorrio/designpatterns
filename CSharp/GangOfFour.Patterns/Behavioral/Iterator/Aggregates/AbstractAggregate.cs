using GangOfFour.Patterns.Behavioral.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Patterns.Behavioral.Iterator.Aggregates
{
    public abstract class AbstractAggregate
    {
        public abstract IIterator GetIterator();
    }
}
