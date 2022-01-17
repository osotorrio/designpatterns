using System.Collections.Generic;
using System.Linq;
using GangOfFour.Patterns.Structural.Composite.Components;

namespace GangOfFour.Patterns.Structural.Composite.Composites
{
    public class BundleCourseComposite : CourseComponent, IComposite
    {
        private readonly List<CourseComponent> _courses = new();

        public BundleCourseComposite(string name, decimal price) : base(name, price) { }

        public void AddCurse(CourseComponent course)
        {
            _courses.Add(course);
        }

        public void RemoveCurse(CourseComponent course)
        {
            _courses.Remove(course);
        }

        public override decimal CalculatePrice()
        {
            return _courses.Sum(course => course.CalculatePrice());
        }
    }
}
