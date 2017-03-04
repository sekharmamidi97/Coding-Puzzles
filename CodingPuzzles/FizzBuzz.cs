using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class FizzBuzz
    {
        public void CheckFizzBuzz()
        {
            for (int i = 1; i <= 1000; i++)
            {
                var result = GetFizzBuzzResult(i);
                Console.WriteLine(result);
            }
        }

        public string GetFizzBuzzResult(int i)
        {
            string result = string.Empty;
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                result = "FizzBuzz";
            }

            if (i % 3 == 0)
            {
                result = "Fizz";
            }

            if (i % 5 == 0)
            {
                result = "Buzz";
            }

            if (string.IsNullOrEmpty(result))
            {
                result = i.ToString();
            }
            return result;

        }

    }
}




