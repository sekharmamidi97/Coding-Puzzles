using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataNumbersToWordsTests
    {
        [TestMethod]
        public void Number_0_To_String_Zero()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("zero", ntw.NumbersToWords(0));
        }

        [TestMethod]
        public void Number_1_To_String_One()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one", ntw.NumbersToWords(1));

        }

        [TestMethod]
        public void Number_7_To_String_Seven()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("seven", ntw.NumbersToWords(7));
        }

        [TestMethod]
        public void Number_15_To_String_Fifteen()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("fifteen", ntw.NumbersToWords(15));
        }

        [TestMethod]
        public void Number_25_To_String_Twenty_Five()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("twenty five", ntw.NumbersToWords(25));
        }

        [TestMethod]
        public void Number_125_To_String_One_Hundred_Twenty_Five()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one hundred twenty five", ntw.NumbersToWords(125));
        }

        [TestMethod]
        public void Number_1502_To_String_One_Thousand_Five_Hundred_Two()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one thousand five hundred two", ntw.NumbersToWords(1502));
        }

        [TestMethod]
        public void Number_10500_To_String_Ten_Thousand_Five_Hundred()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("ten thousand five hundred", ntw.NumbersToWords(10500));
        }

        [TestMethod]
        public void Number_106750_To_String_One_Hundred_Six_Thousand_Seven_Hundred_Fifty()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one hundred six thousand seven hundred fifty", ntw.NumbersToWords(106750));
        }

        [TestMethod]
        public void Number_1234567_To_String_One_Million_Two_Hundred_Thirty_Four_Thousand_Five_Hundred_Sixty_Seven()
        {
            KataNumbersToWords ntw = new KataNumbersToWords();
            Assert.AreEqual("one million two hundred thirty four thousand five hundred sixty seven", ntw.NumbersToWords(1234567));
        }
    }
}
