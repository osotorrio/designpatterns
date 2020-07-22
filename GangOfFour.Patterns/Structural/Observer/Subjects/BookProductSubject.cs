namespace GangOfFour.Patterns.Structural.Observer
{
    public class BookProductSubject : AbstractProductSubject
    {
        private decimal _price;

        public string Title { get; }
        
        public string ISBN { get; }

        public BookProductSubject(string title, string isbn, decimal initialPrice)
        {
            Title = title;
            ISBN = isbn;
            _price = initialPrice;
        }

        public decimal Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < _price) // Notify only when the price goes down
                {
                    _price = value;
                    base.Notify();
                }
            }
        }
    }
}
