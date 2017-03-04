using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
   public class KataFizzBuzz
    {
        public string FizzBuzz(int i)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                return "FizzBuzz";
            }

            else if (i % 3 == 0 || i.ToString().Contains("3"))
            {
                return "Fizz";
            }

            else if (i % 5 == 0 || i.ToString().Contains("5"))
            {
                return "Buzz";
            }

            else
            {
                return i.ToString();
            }
        }
    }
}
