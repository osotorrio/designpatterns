using Xunit;
using GangOfFour.Patterns.Creational.Builder.Builders;
using GangOfFour.Patterns.Creational.Builder.Directors;

namespace GangOfFour.Patterns.Creational.Builder.Client
{
    /// <summary>
    /// Application code
    /// </summary>
    public class Application
    {
        [Fact]
        public void ExampleBuilderPattern()
        {
            var packages = new HolidayPackages();
            var scheduleBuilder = new ScheduleBuilder();
            var priceBuilder = new PriceBuilder();

            packages.BuildWeekendHoliday(scheduleBuilder);
            var schedule = scheduleBuilder.Build();

            packages.BuildWeekendHoliday(priceBuilder);
            var price = priceBuilder.Build();
        }
    }
}