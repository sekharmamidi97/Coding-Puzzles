using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class DeduplicationTest
    {
        [TestMethod]
        public void New_Array_Contains_No_Duplicates()
        {
            Deduplication dd = new Deduplication();

            CollectionAssert.DoesNotContain(new int[] { 8, 13, 13, 9, 11, 12 }, dd.ArrayDeduplication(new int[] { 8, 13, 9, 11, 12 }));
        }
    }
}
