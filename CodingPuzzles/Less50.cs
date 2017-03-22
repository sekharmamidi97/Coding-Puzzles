using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class Less50
    {
        /*
        Return true if the given non-negative number is 4 or 5 less than a multiple of 50. So for example 45 
        and 46 return true, but 50 returns false. 
        (Hint: Think "mod".)
        less50(45) → true
        less50(46) → true
        less50(50) → false
        */

        public bool Less50Exercise(int number)
        {
            bool fourLessThanMultipleOfFifty = (number % 50 == 46);
            bool fiveLessThanMultipleOfFifty = (number % 50 == 45);

            return fourLessThanMultipleOfFifty || fiveLessThanMultipleOfFifty;            
        }
       
    }
}
