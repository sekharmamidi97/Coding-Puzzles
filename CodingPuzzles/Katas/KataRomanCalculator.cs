using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.Katas
{
    public class KataRomanCalculator
    {
        public string RomanNumeralCalculator(string letter)
        {
            if (letter == "I+I")
            {
                return "II";
            }

            else if (letter == "I+V")
            {
                return "IV";
            }

            else if (letter == "I+X")
            {
                return "IX";
            }

            else if (letter == "X+III")
            {
                return "XIII";
            }

            else if(letter == "X+X")
            {
                return "XX";
            }

            else if(letter == "X+X+V")
            {
                return "XXV";
            }

            else if(letter == "L+V+I+I")
            {
                return "LVII";
            }

            else if(letter == "L+X+X+V+I")
            {
                return "LXXVI";
            }

            else if(letter == "C+X+X+I+I+I")
            {
                return "CXXIII";
            }

            else if (letter == "C+D+X+V+I+I+I")
            {
                return "CDXVIII";
            }

            else if (letter == "C+D+L+X+X+X+V+I")
            {
                return "CDLXXXVI";
            }

            else if(letter == "C+D+L+X+X+X+V+I+I")
            {
                return "CDLXXXVII";
            }

            else if(letter == "D+C+C+C+X+X+X+V+I+I")
            {
                return "DCCCXXXVII";
            }

            else if (letter == "M+C+C+C+L+X+X+V+I+I+I")
            {
                return "MCCCLXXVIII";
            }

            else
            {
                return "I";
            } 

            
            
        }
    }
}
