using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
   public class LeastCommonMultiple
    {
        public static int FindLeastCommonMultiple(int s, int m)
        {
            int number1, number2;
            if (s > m)
            {
                number1 = s;
                number2 = m;
            }

            else
            {
                number1 = m;
                number2 = s;
            }

            for (int i = 1; i < number2; i++)
            {
                if ((number1 * i) % number2 == 0)
                {
                    return i * number1;
                }

            }
            return number1 * number2;
        }
    }
}
