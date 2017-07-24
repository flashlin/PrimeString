using System;
using NUnit.Framework;

namespace PrimeStringTests
{
    [TestFixture]
    public class PrimeStringTest
    {
        [Test]
        [TestCase("abac", true)]
        [TestCase("abab", false)]
        [TestCase("aaaa", false)]
        [TestCase("x", true)]
        [TestCase("abc", true)]
        [TestCase("fdsyffdsyffdsyffdsyffdsyf", false)]
        [TestCase("utdutdtdutd", true)]
        [TestCase("abba", true)]
        [TestCase("ccccc", false)]
        public void IsPrimeString(string inputValue, bool isPrimeString)
        {
            // Arrange
            var primeStr = new PrimeString.PrimeString();

            // Act
            bool result = primeStr.IsPrimeString(inputValue);

            // Assert
            Assert.AreEqual(isPrimeString, result);
        }
    }
}
