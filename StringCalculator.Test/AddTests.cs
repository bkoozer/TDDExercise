using System;
using NUnit.Framework;

namespace StringCalculator.Test
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(3, calc.Add("1,2"));
        }

        [Test]
        public void ShouldReturnZeroIfInputEmpty()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Add(""));
        }

        [Test]
        public void ShouldReturnZeroIfInputNull()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Add(null));
        }

        [Test]
        public void ShouldHandleUnknownAmountOfNumbers()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(6, calc.Add("1,2,3"));
            Assert.AreEqual(15, calc.Add("5,4,3,2,1"));
        }
        [Test]
        public void ShouldAllowNewLineAsDelimiter()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(6, calc.Add("1\n2,3"));
        }
        [Test]
        public void ShouldAcceptAlternateDelimiters()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(3, calc.Add("//:\n1:2"));
            Assert.AreEqual(10, calc.Add("//*\n2*2,6"));
        }
    }
}
