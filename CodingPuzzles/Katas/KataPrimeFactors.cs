using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.Katas
{
    public class KataPrimeFactors
    {
        public int [] PrimeFactors(int value)
        {
            List<int> result = new List<int>();
            if (value > 1)
            {
                for (int i = 2; i <= value / 2; i++)
                {
                    while (value % i == 0)
                    {
                        result.Add(i);
                        value = value / i;

                    }
                }

                if (value > 1)
                {
                    result.Add(value);
                }

            }
            return result.ToArray();
        }
    }
}
