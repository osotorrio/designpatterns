using System;
using GangOfFour.Patterns.Creational.Builder.Builders;
using GangOfFour.Patterns.Creational.Builder.Directors;
using Shouldly;
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
            var scheduleBuilder = new ScheduleSummaryBuilder();
            var priceBuilder = new PriceSummaryBuilder();

            packages.ConfigureStandardHolidayPackage(priceBuilder);
            var priceStandardHoliday = priceBuilder.Build();
            priceStandardHoliday.CalculateTotalPrice().ShouldBe(1582.50m);

            packages.ConfigureStandardHolidayPackage(scheduleBuilder);
            var scheduleStandardHoliday = scheduleBuilder.Build();
            scheduleStandardHoliday.PrintoutSchedule().ShouldBe(
                $"Flying from 12/30/2021 9:00:00 AM to 1/6/2022 9:00:00 AM{_nl}Hotel from 12/30/2021 12:00:00 PM to 1/6/2022 12:00:00 PM{_nl}Theme park on the date 12/30/2021 2:00:00 PM{_nl}");

            priceBuilder.Reset();
            scheduleBuilder.Reset();

            packages.ConfigureVipHolidayPackage(priceBuilder);
            var priceVipHoliday = priceBuilder.Build();
            priceVipHoliday.CalculateTotalPrice().ShouldBe(2117.50m);

            packages.ConfigureVipHolidayPackage(scheduleBuilder);
            var scheduleVipHoliday = scheduleBuilder.Build();
            scheduleVipHoliday.PrintoutSchedule().ShouldBe(
                $@"Flying from 12/30/2021 9:00:00 AM to 1/6/2022 9:00:00 AM{_nl}Hotel from 12/30/2021 12:00:00 PM to 1/6/2022 12:00:00 PM{_nl}Dinner on the date 12/30/2021 7:00:00 PM{_nl}Party out on the date 12/30/2021 10:00:00 PM{_nl}");
        }
    }
}
