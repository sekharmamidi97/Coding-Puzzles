using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataRomanCalculatorTests
    {
        [TestMethod]
        public void String_I_Returns_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("I", krc.RomanNumeralCalculator("I"));
        }

        [TestMethod]
        public void String_I_Plus_I_Returns_II()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("II", krc.RomanNumeralCalculator("I+I"));
        }

        [TestMethod]
        public void String_I_Plus_V_Returns_IV()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("IV", krc.RomanNumeralCalculator("I+V"));
        }

        [TestMethod]
        public void String_I_Plus_X_Returns_IX()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("IX", krc.RomanNumeralCalculator("I+X"));
        }

        [TestMethod]
        public void String_X_Plus_III_Returns_XIII()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("XIII", krc.RomanNumeralCalculator("X+III"));
        }

        [TestMethod]
        public void String_X_Plus_X_Returns_XX()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("XX", krc.RomanNumeralCalculator("X+X"));
        }

        [TestMethod]
        public void String_X_Plus_X_Plus_V_Returns_XXV()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("XXV", krc.RomanNumeralCalculator("X+X+V"));
        }

        [TestMethod]
        public void String_L_Plus_V_Plus_I_Plus_I_Returns_LVII()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("LVII", krc.RomanNumeralCalculator("L+V+I+I"));
        }

        [TestMethod]
        public void String_L_Plus_X_Plus_X_Plus_V_Plus_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("LXXVI", krc.RomanNumeralCalculator("L+X+X+V+I"));
        }

        [TestMethod]
        public void String_C_Plus_X_Plus_X_Plus_I_Plus_I_PlusI()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("CXXIII", krc.RomanNumeralCalculator("C+X+X+I+I+I"));
        }

        [TestMethod]
        public void String_C_Plus_D_Plus_X_Plus_V_Plus_I_Plus_I_PlusI()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("CDXVIII", krc.RomanNumeralCalculator("C+D+X+V+I+I+I"));
        }

        [TestMethod]
        public void String_C_Plus_D_Plus_L_Plus_X_Plus_X_Plus_X_Plus_V_Plus_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("CDLXXXVI", krc.RomanNumeralCalculator("C+D+L+X+X+X+V+I"));
        }

        [TestMethod]
        public void String_C_Plus_D_Plus_L_Plus_X_Plus_X_Plus_X_Plus_V_Plus_I_Plus_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("CDLXXXVII", krc.RomanNumeralCalculator("C+D+L+X+X+X+V+I+I"));
        }

        [TestMethod]
        public void String_D_Plus_C_Plus_C_Plus_C_Plus_X_Plus_X_Plus_X_Plus_V_Plus_I_Plus_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("DCCCXXXVII", krc.RomanNumeralCalculator("D+C+C+C+X+X+X+V+I+I"));
        }

        [TestMethod]
        public void String_M_Plus_C_Plus_C_Plus_C_Plus_L_Plus_X_Plus_X_Plus_V_Plus_I_Plus_I_Plus_I()
        {
            KataRomanCalculator krc = new KataRomanCalculator();
            Assert.AreEqual("MCCCLXXVIII", krc.RomanNumeralCalculator("M+C+C+C+L+X+X+V+I+I+I"));
        }
    }
}
