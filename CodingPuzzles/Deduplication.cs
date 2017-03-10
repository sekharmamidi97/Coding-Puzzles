using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
   public class Deduplication
    {
        /*
        Given an integer array, return the array with all of the duplicate values removed.         

        ArrayDeduplication([8, 13, 13, 9, 11, 12]) → [8, 13, 9, 11, 12]
        ArrayDeduplication([]) → []        
        ArrayDeduplication([1, 1, 1]) → [1]
        */

        public int[] ArrayDeduplication(int[] nums)
        {
            //Create a new hash set with nonduplicate numbers
            HashSet<int> nonDuplicate = new HashSet<int>();

            //Create a for loop to loop through array
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                // Check to see nonDuplicate does not contain value, then add it to nonduplicate
                if (!nonDuplicate.Contains(value))
                {
                    nonDuplicate.Add(value);
                }
            }
            // return nonDuplicate and change it to an array
            return nonDuplicate.ToArray();
        }
    }
}
