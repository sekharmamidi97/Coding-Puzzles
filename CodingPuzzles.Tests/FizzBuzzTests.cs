using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_Int_StringNumber()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("7", fb.GetFizzBuzzResult(7));
        }

        [TestMethod]
        public void FizzBuzz_Three_StringFizz()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("Fizz", fb.GetFizzBuzzResult(3));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleByThree_StringFizz()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("Fizz", fb.GetFizzBuzzResult(39));
        }

        [TestMethod]
        public void FizzBuzz_Five_StringFizz()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("Buzz", fb.GetFizzBuzzResult(5));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleByFive_StringBuzz()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("Buzz", fb.GetFizzBuzzResult(35));

        }

    }
}
