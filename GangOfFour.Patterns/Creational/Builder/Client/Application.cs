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

            packages.ConfigureStandardHolidayPackage(priceBuilder);
            var priceStandardHoliday = priceBuilder.Build();
            priceStandardHoliday.CalculateTotalPrice().ShouldBe(1582.50m);

            packages.ConfigureStandardHolidayPackage(scheduleBuilder);
            var scheduleStarndardHoliday = scheduleBuilder.Build();
            scheduleStarndardHoliday.PrintoutSchedule().ShouldBe(
                $"Flying from 30-Dec-21 9:00:00 AM to 06-Jan-22 9:00:00 AM{_nl}Hotel from 30-Dec-21 12:00:00 PM to 06-Jan-22 12:00:00 PM{_nl}Theme park on the date 30-Dec-21 2:00:00 PM{_nl}");

            priceBuilder.Reset();
            scheduleBuilder.Reset();

            packages.ConfigureVipHolidayPackage(priceBuilder);
            var priceVipHoliday = priceBuilder.Build();
            priceVipHoliday.CalculateTotalPrice().ShouldBe(2117.50m);

            packages.ConfigureVipHolidayPackage(scheduleBuilder);
            var scheduleVipHoliday = scheduleBuilder.Build();
            scheduleVipHoliday.PrintoutSchedule().ShouldBe(
                $@"Flying from 30-Dec-21 9:00:00 AM to 06-Jan-22 9:00:00 AM{_nl}Hotel from 30-Dec-21 12:00:00 PM to 06-Jan-22 12:00:00 PM{_nl}Dinner on the date 30-Dec-21 7:00:00 PM{_nl}Party out on the date 30-Dec-21 10:00:00 PM{_nl}");
        }
    }
}
