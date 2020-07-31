using System;

namespace GangOfFour.Patterns.Behavioral.Observer
{
    public interface IAbstractCustomerObserver
    {
        Guid CustomerId { get; }

        string CustomerName { get; }

        void Update(AbstractProductSubject productAbstractSubject);
    }
}