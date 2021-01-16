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
        private readonly string _nl = Environment.NewLine;

        [Fact]
        public void ExampleBuilderPattern()
        {
            var packages = new HolidayPackages();
            var scheduleBuilder = new ScheduleBuilder();
            var priceBuilder = new PriceBuilder();

            packages.BuildStandardHolidayPackage(priceBuilder);
            var priceStandardHoliday = priceBuilder.Build();
            priceStandardHoliday.CalculateTotalPrice().ShouldBe(1482.50M);

            priceBuilder.Reset();

            packages.BuildVipHolidayPackage(priceBuilder);
            var priceVipHoliday = priceBuilder.Build();
            priceVipHoliday.CalculateTotalPrice().ShouldBe(2217.50m);


            packages.BuildStandardHolidayPackage(scheduleBuilder);
            var scheduleStarndardHoldiays = scheduleBuilder.Build();
            scheduleStarndardHoldiays.PrintoutSchedule().ShouldBe(
                $"Holidays from 30-Dec-21 9:00:00 AM to 06-Jan-22 9:00:00 AM{_nl}Staying in hotel from 30-Dec-21 12:00:00 PM to 06-Jan-22 12:00:00 PM{_nl}");

            scheduleBuilder.Reset();

            packages.BuildVipHolidayPackage(scheduleBuilder);
            var scheduleVipHoldiays = scheduleBuilder.Build();
            scheduleVipHoldiays.PrintoutSchedule().ShouldBe(
                $@"Holidays from 30-Dec-21 9:00:00 AM to 06-Jan-22 9:00:00 AM{_nl}Staying in hotel from 30-Dec-21 12:00:00 PM to 06-Jan-22 12:00:00 PM{_nl}Fun in the theme park on the date 30-Dec-21 2:00:00 PM{_nl}Having dinner on the date 30-Dec-21 7:00:00 PM{_nl}Party out all night on the date 30-Dec-21 10:00:00 PM{_nl}");
        }
    }
}
