using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.Katas
{
    public class KataNumbersToWords
    {
        public string NumbersToWords(int number)
        {
            Dictionary<int, string> values = new Dictionary<int, string>()
            {
                {0, "zero" },
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {20, "twenty" },
                {30, "thirty" },
                {40, "forty" },
                {50, "fifty" },
                {60, "sixty" },
                {70, "seventy" },
                {80, "eighty" },
                {90, "ninety" },
                
            };

            if (number >= 1000)
            {
                return NumbersToWords(number / 1000) + "thousand " + NumbersToWords(number % 1000);
            }

            if (number >= 100)
            {
                return NumbersToWords(number / 100) + "hundred " + NumbersToWords(number % 100);
            }

            if (number >= 21)
            {
                return NumbersToWords(number / 10 * 10) + " " + NumbersToWords(number % 10);
            }

            return NumbersToWords(number).ToString();
        }
    }
}
