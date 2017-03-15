using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class Sort
    {
        /*
        Given an integer array, return the array sorted lowest to highest.
        CHALLENGE: Write the Sort algorithm, don't use the .Sort() method provided to an array. 

        sort([8, 13, 9, 12]) → [8, 9, 12, 13]        
        */
        public int[] ArraySort(int[] nums)
        {
            int sort = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        sort = nums[i];
                        nums[i] = nums[j];
                        nums[j] = sort;
                    }

                }
            }
            return nums;
        }
    }
}
