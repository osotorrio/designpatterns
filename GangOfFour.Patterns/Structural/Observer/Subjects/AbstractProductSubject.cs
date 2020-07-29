using System.Collections.Generic;

namespace GangOfFour.Patterns.Structural.Observer
{
    public abstract class AbstractProductSubject
    {
        private readonly List<IAbstractCustomerObserver> _observers = new List<IAbstractCustomerObserver>();

        public void Attach(IAbstractCustomerObserver customerObserver)
        {
            _observers.Add(customerObserver);
        }

        public void Detach(IAbstractCustomerObserver customerObserver)
        {
            _observers.Remove(customerObserver);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
