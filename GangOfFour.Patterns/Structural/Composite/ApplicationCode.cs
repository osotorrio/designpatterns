using GangOfFour.Patterns.Structural.Composite.Composites;
using GangOfFour.Patterns.Structural.Composite.Leafs;
using Shouldly;
using Xunit;

namespace GangOfFour.Patterns.Structural.Composite
{
    /*
         - Programming
         ---- Fundamentals
         ---- Databases
         -------- Sql
         -------- NoSql
         ---- Languages
         -------- Programming Paradigms
         -------- Functional Languages
         ------------ Haskell
         ------------ F#
         -------- Object Oriented Languages
         ------------ C#
         ------------ Java
     */

    public class ApplicationCode
    {
        [Fact]
        public void ExampleCompositePattern()
        {
            // Leafs
            var fundamentals = new SingleCourseLeaf("Fundamentals", 25.99m);
            var sqlDatabases = new SingleCourseLeaf("Sql Databases", 40.50m);
            var noSqlDatabases = new SingleCourseLeaf("NoSql Databases", 50.25m);
            var paradigms = new SingleCourseLeaf("Programming Paradigms", 99.99m);
            var haskel = new SingleCourseLeaf("Haskell", 60.35m);
            var fSharp = new SingleCourseLeaf("F#", 35.99m);
            var cSharp = new SingleCourseLeaf("C#", 32.99m);
            var java = new SingleCourseLeaf("Java", 30.00m);

            // Composites
            var programmingCourses = new BundleCourseComposite("Programming", 0.00m);
            var databases = new BundleCourseComposite("Databases", 0.00m);
            var languages = new BundleCourseComposite("Languages", 0.00m);
            var functionalLanguages = new BundleCourseComposite("Functional Languages", 0.00m);
            var ooLanguages = new BundleCourseComposite("Object Oriented Languages", 0.00m);

            // Tree
            ooLanguages.AddCurse(cSharp);
            ooLanguages.AddCurse(java);

            functionalLanguages.AddCurse(fSharp);
            functionalLanguages.AddCurse(haskel);

            languages.AddCurse(ooLanguages);
            languages.AddCurse(functionalLanguages);
            languages.AddCurse(paradigms);

            databases.AddCurse(sqlDatabases);
            databases.AddCurse(noSqlDatabases);

            programmingCourses.AddCurse(fundamentals);
            programmingCourses.AddCurse(databases);
            programmingCourses.AddCurse(languages);

            // Acting on a group of objects
            var totalPrice = programmingCourses.CalculatePrice();
            totalPrice.ShouldBe(376.06m);

            var databaseCoursesPrice = databases.CalculatePrice();
            databaseCoursesPrice.ShouldBe(90.75m);
        }
    }
}
