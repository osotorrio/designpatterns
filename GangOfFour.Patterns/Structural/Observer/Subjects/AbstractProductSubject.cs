using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

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
            for (int i = 0; i < _observers.Count(); i++)
            {
                _observers[i].Update(this);
            }
        }

        /*
             NOTE: A foreach cannot be used.

             We expect the observers to change the collection while looping and foreach does not allow that.
             We could use a foreach if we use _observers.ToList() which will create a copy of the collection.

            foreach (var observer in _observers.ToList())
            {
                observer.Update(this);
            }
        */
    }
}
