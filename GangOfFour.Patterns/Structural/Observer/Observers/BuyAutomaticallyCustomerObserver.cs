using System;

namespace GangOfFour.Patterns.Structural.Observer.Subjects
{
    public class BuyAutomaticallyCustomerObserver : IAmCustomerObserver
    {
        private AbstractProductSubject _product;

        public Guid CustomerId { get; set; }
        
        public string CustomerName { get; set; }

        public BuyAutomaticallyCustomerObserver(Guid customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public void Update(AbstractProductSubject productAbstractSubject)
        {
            _product = productAbstractSubject;
            BuyAutomatically();
        }

        private void BuyAutomatically()
        {
            /*
            Here the code to buy the product automatically after the price has changed. 
            For instance:

            repository.Save(CustomerId, _product.ISBN, _product.Price);
             */

            _product.Detach(this); // The customer would like to buy this product only once.
        }
    }
}
