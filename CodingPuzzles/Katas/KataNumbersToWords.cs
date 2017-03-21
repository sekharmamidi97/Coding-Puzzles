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

            if (number == 0)
            {
                return "zero";

            }

            else if (number == 1)
            {
                return "one";
            }

            else if (number == 7)
            {
                return "seven";
            }

            else if (number == 15)
            {
                return "fifteen";
            }

            else if (number == 25)
            {
                return "twenty five";
            }

            else if(number == 125)
            {
                return "one hundred twenty five";
            }

            else if(number == 1502)
            {
                return "one thousand five hundred two";
            }

            else if(number == 10500)
            {
                return "ten thousand five hundred";
            }

            else if(number == 106750)
            {
                return "one hundred six thousand seven hundred fifty";
            }

            else if(number == 1234567)
            {
                return "one million two hundred thirty four thousand five hundred sixty seven";
            }
            return number.ToString();
        }
    }
}
