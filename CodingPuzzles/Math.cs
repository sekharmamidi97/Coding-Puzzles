using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class Math
    {
        public int Math1(int sum)
        {
            double[] addArray = { 78.2, 76, 102.8, 65, 97.8, 67, 128 };
            sum = (int)addArray.Sum();

            if (sum > 100)
            {
                Console.WriteLine("When adding these numbers, the sum is greater than 100!");

            }

            else
            {
                Console.WriteLine("When adding these numbers, the sum is less than 100!");

            }
            return sum;
        }

        public int Math2(int add)
        {
            double[] arraySum = { 106.1, 800, 52, 77, 23, 42 };
            add = (int)arraySum.Sum();

            if (add < 200)
            {
                Console.WriteLine("When adding these numbers, the total is less than 200");
                Console.WriteLine(add);
            }

            else
            {
                Console.WriteLine("When adding these numbers, the total is greater than 200!");
                Console.WriteLine(add);
            }
            return add;
        }

        public int Math3(int addition)
        {
            double[] arryNum = { 45, 822, 658.7, 95, 87, 78.558 };
            addition = (int)arryNum.Sum();

            if (addition > 300)
            {
                Console.WriteLine("When adding these numbers, the total is greater than 300!");

            }

            else
            {
                Console.WriteLine("When adding these numbers, the total is less than 300!");

            }
            return addition;
        }

        public int Math4(int max)
        {
            double[] newArray = { 5000, 423.765, 85, 48, 158.52, 101.9 };
            max = (int)newArray.Max();

            if (max < 400)
            {
                Console.WriteLine("The maximum value in this array is less than 400!");

            }

            else
            {
                Console.WriteLine("The maximum value in this array is greater than 400!");

            }
            return max;

        }

        public int Math5(int min)
        {
            double[] numArray = { 652.4, 47, 958, 4785.5, 500, 62 };
            min = (int)numArray.Min();

            if (min > 500)
            {
                Console.WriteLine("The minimum value in this array is greater than 500!");

            }

            else
            {
                Console.WriteLine("The minimum value in this array is less than 500!");

            }
            return min;

        }
    }
}
