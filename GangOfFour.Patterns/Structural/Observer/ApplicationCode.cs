﻿using GangOfFour.Patterns.Structural.Observer.Subjects;
using System;
using Xunit;

namespace GangOfFour.Patterns.Structural.Observer
{
    public class ApplicationCode
    {
        [Fact]
        public void ExampleObserverPattern()
        {
            IAbstractCustomerObserver customerBobby = new BuyAutomaticallyCustomerObserver(Guid.NewGuid(), "Robert Fischer");
            IAbstractCustomerObserver customerTigran = new GoodToKnowCustomerObserver(Guid.NewGuid(), "Tigran Petrosian");

            BookProductSubject kasparovBook = new BookProductSubject("Garry Kasparov on My Great Predecessors", "978-1781945155", 19.95m);

            kasparovBook.Attach(customerBobby);
            kasparovBook.Attach(customerTigran);

            kasparovBook.Price = 14.99m;
        }
    }
}
