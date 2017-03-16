using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class StringMaxBlock
    {
        /*
        CHALLENGE: Given a string, return the length of the largest "block" in the string. 
        A block is a run of adjacent chars that are the same.

        maxBlock("hoopla") → 2
        maxBlock("abbCCCddBBBxx") → 3
        maxBlock("") → 0
        */
        public int MaxBlock(string str)
        {
            int length = 0;
            int count = 1;

            if (str.Length == 0)
            {
                return 0;
            }

            if (str.Length == 1)
            {
                return 1;
            }

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    ++count;
                    if (count > length)
                    {
                        length = count;
                    }
                }

                else
                {
                    count = 1;
                }

                if (count > length)
                {
                    length = count;
                }
            }
            return length;
        }
    }
}
