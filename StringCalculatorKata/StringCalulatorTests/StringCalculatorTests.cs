using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalulatorTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddsEmptyString()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddsOneNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void AddsTwoNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsThreeNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AddsFourNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3,4");

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void AddsNumbersWithNewLines()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1\n2,3");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AddsNumbersWithNewLinesAndCommasMixed()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1\n2,3,\n,4,\n5");

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NoNegativesAllowedException))]
        public void NegativeNumberThrowsAnException()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3,-4");
        }

        [TestMethod]
        [ExpectedException(typeof(NoNegativesAllowedException))]
        public void MultipleNegativeNumbersThrowsAnException()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3,-4,5,-10");
        }
    }
}
