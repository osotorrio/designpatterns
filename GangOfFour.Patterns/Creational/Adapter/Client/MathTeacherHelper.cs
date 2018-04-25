using System;
using GangOfFour.Patterns.Creational.Adapter.Target;

namespace GangOfFour.Patterns.Creational.Adapter.Client
{
    /// <summary>
    /// CLIENT:
    /// This class contains the business logic of the application. We wouldn't like to modify any code here.
    /// </summary>
    public class MathTeacherHelper
    {
        private readonly IArithmeticCalculate _calculatorService;

        public MathTeacherHelper(IArithmeticCalculate calculator)
        {
            _calculatorService = calculator;
        }

        public bool IsAdditionCorrect(double x, double y, double studentAnswer)
        {
            return Execute(_calculatorService.Addition, x, y, studentAnswer);
        }

        public bool IsSubtractionCorrect(double x, double y, double studentAnswer)
        {
            return Execute(_calculatorService.Subtraction, x, y, studentAnswer);
        }

        public bool IsMultiplicationCorrect(double x, double y, double studentAnswer)
        {
            return Execute(_calculatorService.Multiplication, x, y, studentAnswer);
        }

        public bool IsDivisionCorrect(double x, double y, double studentAnswer)
        {
            return Execute(_calculatorService.Division, x, y, studentAnswer);
        }

        private static bool Execute(Func<double, double, double> operation, double x, double y, double studentAnswer)
        {
            var result = operation(x, y);
            return result == studentAnswer;
        }
    }
}
