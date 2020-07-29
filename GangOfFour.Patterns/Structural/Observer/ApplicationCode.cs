using GangOfFour.Patterns.Structural.Observer.Subjects;
using System;

namespace GangOfFour.Patterns.Structural.Observer
{
    public class ApplicationCode
    {
        public void ExampleOfUse()
        {
            IAmCustomerObserver customerBobby = new BuyAutomaticallyCustomerObserver(Guid.NewGuid(), "Robert Fischer");
            IAmCustomerObserver customerTigran = new GoodToKnowCustomerObserver(Guid.NewGuid(), "Tigran Petrosian");

            BookProductSubject kasparovBook = new BookProductSubject("Garry Kasparov on My Great Predecessors", "978-1781945155", 19.95m);

            kasparovBook.Attach(customerBobby);
            kasparovBook.Attach(customerTigran);

            kasparovBook.Price = 14.99m;
        }
    }
}
