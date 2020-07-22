﻿using System;

namespace GangOfFour.Patterns.Structural.Observer
{
    public interface IAmCustomerObserver
    {
        Guid CustomerId { get; }

        string CustomerName { get; }

        void Update(AbstractProductSubject productAbstractSubject);
    }
}