using System;

namespace GangOfFour.Patterns.Structural.Observer.Subjects
{
    public class GoodToKnowCustomerObserver : IAbstractCustomerObserver
    {
        public AbstractProductSubject _product;

        public Guid CustomerId { get; }

        public string CustomerName { get; }

        public GoodToKnowCustomerObserver(Guid customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public void Update(AbstractProductSubject product)
        {
            _product = product;
            SendEmail();
        }

        public void SendEmail()
        {
            /*
            Here the code to notify the customer by email anytime the price has changed.
            For instance:

            emailClient.Send(CustomerId, _product.ISBN, _product.Price);
             */
        }
    }
}
