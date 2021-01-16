using GangOfFour.Patterns.Creational.Builder.Builders;
using GangOfFour.Patterns.Creational.Builder.Directors;
using Shouldly;
using System;
using Xunit;

namespace GangOfFour.Patterns.Creational.Builder.Client
{
    /// <summary>
    /// Application code
    /// </summary>
    public class Application
    {
        private string _nl = Environment.NewLine;

        [Fact]
        public void ExampleBuilderPattern()
        {
            var packages = new HolidayPackages();
            var scheduleBuilder = new ScheduleBuilder();
            var priceBuilder = new PriceBuilder();

            packages.BuildStandardHolidayPackage(scheduleBuilder);
            var schedule = scheduleBuilder.Build();

            packages.BuildStandardHolidayPackage(priceBuilder);
            var price = priceBuilder.Build();

            schedule.PrintoutSchedule().ShouldBe(
                $@"Holidays from 30-Dec-21 9:00:00 AM to 06-Jan-22 9:00:00 AM{_nl}Staying in hotel from 30-Dec-21 12:00:00 PM to 06-Jan-22 12:00:00 PM{_nl}");

            price.CalculateTotalPrice().ShouldBe(1482.50M);
        }
    }
}
