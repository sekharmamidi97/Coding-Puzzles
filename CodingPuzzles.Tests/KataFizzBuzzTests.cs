using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_Four_ReturnStringFour()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("4", kfb.FizzBuzz(4));
        }

        [TestMethod]
        public void FizzBuzz_Seventeen_ReturnStringSeventeen()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("17", kfb.FizzBuzz(17));
        }

        [TestMethod]
        public void FizzBuzz_ReturnFizz_WhenThee()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Fizz", kfb.FizzBuzz(3));
        }
        
        [TestMethod]
        public void FizzBuzz_ReturnFizz_WhenDivisibleByThree()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Fizz", kfb.FizzBuzz(36));
        }

        [TestMethod]
        public void FizzBuzz_ReturnFizz_WhenContainsThree()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Fizz", kfb.FizzBuzz(73));
        }

        [TestMethod]
        public void FizzBuzz_ReturnBuzz_WhenFive()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Buzz", kfb.FizzBuzz(5));
        }

        [TestMethod]
        public void FizzBuzz_ReturnBuzz_WhenDivisibleByFive()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Buzz", kfb.FizzBuzz(25));
        }

        [TestMethod]
        public void FizzBuzz_ReturnBuzz_WhenContainsFive()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("Buzz", kfb.FizzBuzz(55));
        }

        [TestMethod]
        public void FizzBuzz_ReturnFizzBuzz_WhenDivisibleByThreeAndFive()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(90));
        }

        [TestMethod]
        public void FizzBuzz_ReturnsFizzBuzz_WhenDivisibleByThreeAndFive()
        {
            KataFizzBuzz kfb = new KataFizzBuzz();
            Assert.AreEqual("FizzBuzz", kfb.FizzBuzz(360));

        }
    }
}

