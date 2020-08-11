namespace GangOfFour.Patterns.Structural.Composite.Components
{
    public abstract class CourseComponent
    {
        protected string Name { get; set; }

        protected decimal Price { get; set; }

        public CourseComponent(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // This is the common operation we want to act on all objects in the tree (Leafs and Composites)
        public abstract decimal CalculatePrice();
    }
}
