using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class Averages
    {
        public int AverageExercise1(int average)
        {
            int[] newArray = { 75, 62, 87, 190, 25, 76 };
            average = (int)newArray.Average();

            if (average < 50)
            {
                Console.WriteLine("The average is less than 50!");
            }

            else
            {
                Console.WriteLine("The average is greater than 50!");
            }
            return average;
        }

        public int AverageExercise2(int mean)
        {
            int[] numbersArray = { 65, 87, 276, 656, 89, 65 };
            mean = (int)numbersArray.Average();

            if (mean < 100)
            {
                Console.WriteLine("The mean is less than 100!");
            }

            else
            {
                Console.WriteLine("The mean is greater than 100!");
            }
            return mean;
        }

        public int AverageExercise3(int average)
        {
            int[] meanArray = { 56, 45, 197, 800, 54, 754 };
            average = (int)meanArray.Average();

            if (average < 150)
            {
                Console.WriteLine("The average is less than 150!");
            }

            else
            {
                Console.WriteLine("The average is greater than 150!");
            }
            return average;

        }

        public int AverageExercise4(int mean)
        {
            int[] averageArray = { 200, 750, 1000, 455, 222, 125 };
            mean = (int)averageArray.Average();

            if (mean < 275)
            {
                Console.WriteLine("The mean is less than 275");
            }

            else
            {
                Console.WriteLine("The mean is greater than 275");
            }
            return mean;
        }

        public int AverageExercise5(int average)
        {
            int[] arrayAverage = { 78, 425, 10, 62, 954, 42 };
            average = (int)arrayAverage.Average();

            if (average < 500)
            {
                Console.WriteLine("The average is less than 500!");
               
            }

            else
            {
                Console.WriteLine("The average is greater than 500!");
               
            }
            return average;
        }
    }
}
