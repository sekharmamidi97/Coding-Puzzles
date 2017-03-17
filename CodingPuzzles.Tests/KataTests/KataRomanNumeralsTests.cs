using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void Int_1_To_RomanNumeral_I()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("I", krn.RomanNumerals(1));
            
        }

        [TestMethod]
        public void Int_2_To_RomanNumeral_II()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("II", krn.RomanNumerals(2));
        }

        [TestMethod]
        public void Int_4_To_RomanNumeral_IV()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("IV", krn.RomanNumerals(4));
        }

        [TestMethod]
        public void Int_5_To_RomanNumeral_V()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("V", krn.RomanNumerals(5));
        }

        [TestMethod]
        public void Int_8_To_RomanNumeral_VIII()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("VIII", krn.RomanNumerals(8));
        }

        [TestMethod]
        public void Int_9_To_RomanNumeral_IX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("IX", krn.RomanNumerals(9));
        }

        [TestMethod]
        public void Int_10_To_RomanNumeral_X()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("X", krn.RomanNumerals(10));
        }

        [TestMethod]
        public void Int_13_To_RomanNumeral_XIII()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XIII", krn.RomanNumerals(13));
        }

        [TestMethod]
        public void Int_15_To_RomanNumeral_XV()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XV", krn.RomanNumerals(15));
        }

        [TestMethod]
        public void Int_18_To_RomanNumeral_XVIII()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XVIII", krn.RomanNumerals(18));
        }

        [TestMethod]
        public void Int_20_To_RomanNumeral_XX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XX", krn.RomanNumerals(20));
        }

        [TestMethod]
        public void Int_22_To_RomanNumeral_XXII()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXII", krn.RomanNumerals(22));
        }

        [TestMethod]
        public void Int_25_To_RomanNumeral_XXV()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXV", krn.RomanNumerals(25));
        }

        [TestMethod]
        public void Int_29_To_RomanNumeral_XXIX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXIX", krn.RomanNumerals(29));
        }

        [TestMethod]
        public void Int_30_To_RomanNumeral_XXX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXX", krn.RomanNumerals(30));
        }

        [TestMethod]
        public void Int_33_To_RomanNumeral_XXXIII()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXXIII", krn.RomanNumerals(33));
        }

        [TestMethod]
        public void Int_35_To_RomanNumeral_XXXV()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXXV", krn.RomanNumerals(35));
        }

        [TestMethod]
        public void Int_39_To_RomanNumeral_XXXIX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("XXXIX", krn.RomanNumerals(39));
        }

        [TestMethod]
        public void Int_40_To_RomanNumeral_LX()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("LX", krn.RomanNumerals(40));
        }

        [TestMethod]
        public void Int_50_To_RomanNumeral_L()
        {
            KataRomanNumerals krn = new KataRomanNumerals();
            Assert.AreEqual("L", krn.RomanNumerals(50));
        }
    }
}
