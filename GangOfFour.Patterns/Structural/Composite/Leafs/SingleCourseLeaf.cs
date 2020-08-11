using GangOfFour.Patterns.Structural.Composite.Components;

namespace GangOfFour.Patterns.Structural.Composite.Leafs
{
    public class SingleCourseLeaf : CourseComponent
    {
        public SingleCourseLeaf(string name, decimal price) : base(name, price){}

        public override decimal CalculatePrice()
        {
            return Price;
        }
    }
}
