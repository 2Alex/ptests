using NUnit.Framework;

namespace ParameterizedTestSamples.Sample1
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(2, 3)]
        [TestCase(14, 25)]
        [TestCase(3, 5)]
        [TestCase(8, 3)]
        public void IsCoprimeNumbersPositiveTest(int n1, int n2)
        {
            Assert.IsTrue(Calculator.IsCoprimeNumbers(n1, n2));
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 0)]
        [TestCase(2, 2)]        
        [TestCase(2, 4)]        
        public void IsCoprimeNumbersNegativeTest(int n1, int n2)
        {
            Assert.IsFalse(Calculator.IsCoprimeNumbers(n1, n2));
        }
    }
}