using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests
{
    [TestClass]
    public class IntersectionTest
    {
        [TestMethod]
        public void NewArray_Contains_Intersection_Int_TwoArrays()
        {
            Intersection i = new Intersection();

            int[] arrayOne = new int[] { 1, 3, 5 };
            int[] arrayTwo = new int[] { 1, 5, 7 };
            CollectionAssert.DoesNotContain(i.ArrayIntersection(arrayOne,arrayTwo), new[] { 1, 5 });
        }
    }
}
