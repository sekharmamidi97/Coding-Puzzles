using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Array_Sorted()
        {
            Sort s = new Sort();

            CollectionAssert.AreEquivalent(new int[] { 8, 13, 9, 12 }, s.ArraySort(new int[] { 8, 9, 12, 13 }));
        }
    }
}
