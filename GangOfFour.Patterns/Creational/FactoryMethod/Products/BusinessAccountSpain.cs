﻿using System;

namespace GangOfFour.Patterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class BusinessAccountSpain : IBankAccount
    {
        public Guid AccountId => Guid.NewGuid();

        public void CreditAccount(decimal amount)
        {
            /*
                Here the code to increase the balance of the account. For instance:

                repository.UpdateBalance(AccountId, amount);
             */
        }

        public bool OpenAccount(string holder)
        {
            /*
                Here the code to register a new bank account with the holder name. For instance:

                repository.Save(AccountId, holder);
             */

            return true;
        }
    }
}
