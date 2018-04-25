using GangOfFour.Patterns.Creational.Adapter;
using GangOfFour.Patterns.Creational.Adapter.Client;
using GangOfFour.Patterns.Creational.Adapter.Target;
using NSubstitute;
using Shouldly;
using Xbehave;

namespace GangOfFour.Patterns.Tests.Creational.Adapter
{
    public class MathTeacherHelperTests
    {
        [Scenario]
        public void AdditionIsCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the right answer"
                .x(() =>
                {
                    var rightAnswer = studentAnswer = 50;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Addition(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the addition"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsAdditionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeTrue();
                });
        }

        [Scenario]
        public void AdditionIsNotCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the wrong answer"
                .x(() =>
                {
                    var rightAnswer = 50;
                    studentAnswer = 10;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Addition(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the addition"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsAdditionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeFalse();
                });
        }

        [Scenario]
        public void SubtractionIsCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the right answer"
                .x(() =>
                {
                    var rightAnswer = studentAnswer = 50;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Subtraction(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the subtraction"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsSubtractionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeTrue();
                });
        }

        [Scenario]
        public void SubtractionIsNotCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the wrong answer"
                .x(() =>
                {
                    var rightAnswer = 50;
                    studentAnswer = 10;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Subtraction(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the subtraction"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsSubtractionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeFalse();
                });
        }

        [Scenario]
        public void MultiplicationIsCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the right answer"
                .x(() =>
                {
                    var rightAnswer = studentAnswer = 50;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Multiplication(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the multiplication"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsMultiplicationCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeTrue();
                });
        }

        [Scenario]
        public void MultiplicationIsNotCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the wrong answer"
                .x(() =>
                {
                    var rightAnswer = 50;
                    studentAnswer = 10;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Multiplication(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the multiplication"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsSubtractionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeFalse();
                });
        }

        [Scenario]
        public void DivisionIsCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the right answer"
                .x(() =>
                {
                    var rightAnswer = studentAnswer = 50;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Division(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the multiplication"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsDivisionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeTrue();
                });
        }

        [Scenario]
        public void DivisionIsNotCorrectTest(IArithmeticCalculate calculator, MathTeacherHelper mathTeacher, double studentAnswer, bool result)
        {
            "GIVEN the student got the wrong answer"
                .x(() =>
                {
                    var rightAnswer = 50;
                    studentAnswer = 10;

                    calculator = Substitute.For<IArithmeticCalculate>();
                    calculator.Division(Arg.Any<double>(), Arg.Any<double>()).Returns(rightAnswer);
                });

            "WHEN we check out the multiplication"
                .x(() =>
                {
                    mathTeacher = new MathTeacherHelper(calculator);
                    result = mathTeacher.IsDivisionCorrect(10, 5, studentAnswer);
                });

            "THEN it should return true"
                .x(() =>
                {
                    result.ShouldBeFalse();
                });
        }
    }
}
