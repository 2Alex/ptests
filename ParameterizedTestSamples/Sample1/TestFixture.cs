using NUnit.Framework;

namespace ParameterizedTestSamples.Sample1
{
    [TestFixture]
    public class CalculatorTest
    {
        // Позитивы.
        [TestCase(2, 3, Result = true)]
        [TestCase(14, 25, Result = true)]
        [TestCase(3, 5, Result = true)]
        [TestCase(8, 3, Result = true)]
        // Негативы.
        [TestCase(0, 0, Result = false)]
        [TestCase(1, 1, Result = false)]
        [TestCase(1, 0, Result = false)]
        [TestCase(2, 2, Result = false)]
        [TestCase(2, 4, Result = false)]   
        public bool IsCoprimeNumbersPositiveTest(int n1, int n2)
        {
           return Calculator.IsCoprimeNumbers(n1, n2);
        }     
    }
}