using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class ClumpsCount
    {
        /*
        CHALLENGE: Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value.
        Return the number of clumps in the given array.

        countClumps([1, 2, 2, 3, 4, 4]) → 2
        countClumps([1, 1, 2, 1, 1]) → 2
        countClumps([1, 1, 1, 1, 1]) → 1
        */
        public int CountClumps(int[] nums)
        {
            int number = 0;
            int numberOfClumps = 0;

            while (number < nums.Length)
            {
                int numberOne = nums[number];
                number++;
                int arrayLength = 1;
                while (number < nums.Length && nums[number] == numberOne)
                {
                    number++;
                    arrayLength++;
                }
                if (arrayLength > 1)
                {
                    numberOfClumps++;
                }
            }
            return numberOfClumps;
        }

    }

}

