using GangOfFour.Patterns.Structural.Composite.Components;

namespace GangOfFour.Patterns.Structural.Composite.Composites
{
    /*
        Sometimes you can see this methods (children management) inside of the Component.
        But it has the disadvantage that the Leaf object would have an empty implementation of them 
    */

    public interface IComposite
    {
        void AddCurse(CourseComponent course);

        void RemoveCurse(CourseComponent course);
    }
}
