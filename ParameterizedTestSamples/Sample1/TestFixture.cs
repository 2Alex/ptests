using System;
using NUnit.Framework;

namespace ParameterizedTestSamples.Sample1
{
    [TestFixture]
    public class CalculatorTests
    {      
        [Test]
        public void IsCoprimeNumbersTest()
        {
            Assert.IsTrue(Calculator.IsCoprimeNumbers(2, 3));
            Assert.IsTrue(Calculator.IsCoprimeNumbers(14, 25));
            Assert.IsTrue(Calculator.IsCoprimeNumbers(8, 3));            
            Assert.IsTrue(Calculator.IsCoprimeNumbers(3, 5));

            Assert.IsFalse(Calculator.IsCoprimeNumbers(0, 0));
            Assert.IsFalse(Calculator.IsCoprimeNumbers(1, 1));
            Assert.IsFalse(Calculator.IsCoprimeNumbers(1, 0));
            Assert.IsFalse(Calculator.IsCoprimeNumbers(2, 2));
            Assert.IsFalse(Calculator.IsCoprimeNumbers(2, 4));
        }     
    }
}