using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void PrimeNumber_IsTrue()
        {
            Assert.IsTrue(PrimeNumber.isPrime(5));

        }

        [TestMethod]
        public void PrimeNumber_IsFalse()
        {
            Assert.IsFalse(PrimeNumber.isPrime(15));
        }

        [TestMethod]
        public void LargeNumber_IsFalse()
        {
            Assert.IsFalse(PrimeNumber.isPrime(547862));
        }

    }
}
