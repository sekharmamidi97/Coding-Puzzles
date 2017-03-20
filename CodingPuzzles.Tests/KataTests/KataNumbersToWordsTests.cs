using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataNumbersToWordsTests
    {
        [TestMethod]
        public void Number_1_To_String_One()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one", ntw.NumbersToWords(1));

        }
    }
}
