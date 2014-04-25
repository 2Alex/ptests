using NUnit.Framework;

namespace ParameterizedTestSamples.Sample1
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(14, 25)]
        public void IsCoprimeNumbersTest(int n1, int n2)
        {
            Assert.That(Calculator.IsCoprimeNumbers(n1, n2), Is.True);
        }
    }
}