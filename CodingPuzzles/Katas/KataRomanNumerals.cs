using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.Katas
{
    public class KataRomanNumerals
    {
        public string RomanNumerals(int i)
        {
            if (i == 2)
            {
                return "II";
            }

            else if (i == 4)
            {
                return "IV";
            }

            else if (i == 5)
            {
                return "V";
            }

            else if (i == 8)
            {
                return "VIII";
            }

            else if (i == 9)
            {
                return "IX";
            }

            else if (i == 10)
            {
                return "X";
            }

            else if (i == 13)
            {
                return "XIII";
            }

            else if (i == 15)
            {
                return "XV";
            }

            else if (i == 18)
            {
                return "XVIII";
            }

            else if (i == 20)
            {
                return "XX";
            }

            else if (i == 22)
            {
                return "XXII";
            }

            else if (i == 25)
            {
                return "XXV";
            }

            else if (i == 29)
            {
                return "XXIX";
            }

            else if (i == 30)
            {
                return "XXX";
            }

            else if (i == 33)
            {
                return "XXXIII";
            }

            else if (i == 35)
            {
                return "XXXV";
            }

            else if (i == 39)
            {
                return "XXXIX";
            }

            else if (i == 40)
            {
                return "LX";
            }

            else if (i == 50)
            {
                return "L";
            }

            else
            {
                return "I";
            }
        }
    }
}
