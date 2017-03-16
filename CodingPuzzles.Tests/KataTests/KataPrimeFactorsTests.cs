using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingPuzzles.Katas;

namespace CodingPuzzles.Tests.KataTests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void KataPrimeFactors_ReturnEmptyIndex_WhenOne()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { }, kpf.PrimeFactors(1));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorTwo_WhenTwo()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2 }, kpf.PrimeFactors(2));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorThree_WhenThree()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 3 }, kpf.PrimeFactors(3));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorTwo_Two_WhenFour()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 2 }, kpf.PrimeFactors(4));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorTwo_Five_WhenTen()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 5 }, kpf.PrimeFactors(10));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorThree_Three_WhenNine()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 3, 3 }, kpf.PrimeFactors(9));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorFive_Five_WhenTwentyFive()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 5, 5 }, kpf.PrimeFactors(25));
        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorTwo_Two_Two_WhenEight()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, kpf.PrimeFactors(8));

        }

        [TestMethod]
        public void KataPrimeFactors_ReturnPrimeFactorTwo_Five_Seven_ThirteenWhen_Two_Times_Five_Times_Seven_Times_Thirteen()
        {
            KataPrimeFactors kpf = new KataPrimeFactors();
            CollectionAssert.AreEqual(new int[] { 2, 5, 7, 13 }, kpf.PrimeFactors(2 * 5 * 7 * 13));

        }
    }
}





