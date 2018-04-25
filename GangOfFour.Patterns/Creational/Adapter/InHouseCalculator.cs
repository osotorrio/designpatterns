using GangOfFour.Patterns.Creational.Adapter.Target;

namespace GangOfFour.Patterns.Creational.Adapter
{
    /// <summary>
    /// This is the code we would like to deprecate. It is a bad implementation and buggy.
    /// We would like to use instead the new fancy nuget package Dangl.Calculator.
    /// </summary>
    public class InHouseCalculator : IArithmeticCalculate
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            double result = 0;

            for (var i = 0; i < y; i++)
            {
                result += x;
            }

            return result;
        }

        public double Division(double x, double y)
        {
            var result = 1;

            for (var i = 0; i < x; i++)
            {
                x -= y;

                if (x > 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
