using System.Collections.Generic;

namespace GangOfFour.Patterns.Structural.Observer
{
    public abstract class AbstractProductSubject
    {
        private readonly List<IAmCustomerObserver> _observers = new List<IAmCustomerObserver>();

        public void Attach(IAmCustomerObserver customerObserver)
        {
            _observers.Add(customerObserver);
        }

        public void Detach(IAmCustomerObserver customerObserver)
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
