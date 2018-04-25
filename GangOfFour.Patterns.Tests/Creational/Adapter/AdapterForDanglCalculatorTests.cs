using GangOfFour.Patterns.Creational.Adapter;
using GangOfFour.Patterns.Creational.Adapter.Target;
using Shouldly;
using Xbehave;

namespace GangOfFour.Patterns.Tests.Creational.Adapter
{
    public class AdapterForDanglCalculatorTests
    {
        [Scenario]
        [Example(15, 4, 19)]
        public void AdditionTest(double x, double y, double expectedResult, IArithmeticCalculate calculator, double actualResult)
        {
            "GIVEN the Dangl adapter"
                .x(() =>
                {
                    calculator = new AdapterForDanglCalculator();
                });

            $"AND the number {x}"
                .x(() => { });

            $"AND the number {y}"
                .x(() => { });

            "WHEN we add both"
                .x(() =>
                {
                    actualResult = calculator.Addition(x, y);
                });

            $"THEN the result should be {expectedResult}"
                .x(() =>
                {
                    actualResult.ShouldBe(expectedResult);
                });
        }

        [Scenario]
        [Example(15, 4, 11)]
        public void SubstractionTest(double x, double y, double expectedResult, IArithmeticCalculate calculator, double actualResult)
        {
            "GIVEN the Dangl adapter"
                .x(() =>
                {
                    calculator = new AdapterForDanglCalculator();
                });

            $"AND the number {x}"
                .x(() => { });

            $"AND the number {y}"
                .x(() => { });

            "WHEN we substract both"
                .x(() =>
                {
                    actualResult = calculator.Subtraction(x, y);
                });

            $"THEN the result should be {expectedResult}"
                .x(() =>
                {
                    actualResult.ShouldBe(expectedResult);
                });
        }

        [Scenario]
        [Example(15, 4, 60)]
        public void MultiplicationTest(double x, double y, double expectedResult, IArithmeticCalculate calculator, double actualResult)
        {
            "GIVEN the Dangl adapter"
                .x(() =>
                {
                    calculator = new AdapterForDanglCalculator();
                });

            $"AND the number {x}"
                .x(() => { });

            $"AND the number {y}"
                .x(() => {});

            "WHEN we multiple both"
                .x(() =>
                {
                    actualResult = calculator.Multiplication(x, y);
                });

            $"THEN the result should be {expectedResult}"
                .x(() =>
                {
                    actualResult.ShouldBe(expectedResult);
                });
        }

        [Scenario]
        [Example(18, 3, 6)]
        public void DivisionTest(double x, double y, double expectedResult, IArithmeticCalculate calculator, double actualResult)
        {
            "GIVEN the Dangl adapter"
                .x(() =>
                {
                    calculator = new AdapterForDanglCalculator();
                });

            $"AND the number {x}"
                .x(() => { });

            $"AND the number {y}"
                .x(() => { });

            "WHEN we devide both"
                .x(() =>
                {
                    actualResult = calculator.Division(x, y);
                });

            $"THEN the result should be {expectedResult}"
                .x(() =>
                {
                    actualResult.ShouldBe(expectedResult);
                });
        }
    }
}
