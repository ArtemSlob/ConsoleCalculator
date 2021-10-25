using NUnit.Framework;
using ConsoleCalculator;

namespace ConsoleCalculator.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 2, 12)]
        [TestCase(-14, 8, -6)]
        [TestCase(0, 3, 3)]
        [TestCase(1, 1, 2)]
        public void AdditionalTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Sum(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 8)]
        [TestCase(-10, 8, -18)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        public void SubstractionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Subtract(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 20)]
        [TestCase(-10, 8, -80)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        public void MultiplyTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 3, 1)]
        [TestCase(-10, 8, -2)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 0)]
        public void RestOfDivideTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(-10, -10, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        public void DivideTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Divide(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9, 3)]
        [TestCase(4, 2)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void SqrtTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Sqrt(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(7, 5040)]
        [TestCase(20, 2432902008176640000)]
        public void FactorialTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(-2, 4)]
        [TestCase(8, 64)]
        [TestCase(1, 1)]
        public void PowerTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Power(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}