using System;
using System.Linq;

namespace Exercise3A
{
    class Program
    {
        static void Main(string[] args)
        {
            // SUM OF TEN NUMBERS
               sumArray();
               
            // AVERAGE TEN SCORES
               avgScores();

            // AVERAGE A SPECIFIC NUMBER OF SCORES
               yourAverage();

            // AVERAGE A NON-SPECIFIC NUMBER OF SCORES
                int[] array = inputToArray();
                arrayAveraged(array);

            /*       This section was used to verify that my process was valid
             *       
                        printArray(array);
                        Console.WriteLine();
                        Console.WriteLine(sumArray);
                        Console.WriteLine(average);
            */
        }

        private static void arrayAveraged(int[] array)
        {
            double sumArray = array.Aggregate((a, b) => a + b);
            double average = sumArray / array.Length;


            if (average >= 90)
            {
                Console.WriteLine($"The average grade was {average} which is an A");
            }

            else if (average >= 80)
            {
                Console.WriteLine($"The average grade was {average} which is a B");
            }
            else if (average >= 70)
            {
                Console.WriteLine($"The average grade was {average} which is a C");
            }
            else if (average >= 60)
            {
                Console.WriteLine($"The average grade was {average} which is a D");
            }
            else
            {
                Console.WriteLine($"The average grade was {average} which is an F");
            }
        }

        private static int[] inputToArray()
        {
            Console.WriteLine(" Enter your test scores seperated by a comma");
            var list = Console.ReadLine();

            int[] array = list.Split(",")
                           .Select(int.Parse)
                           .ToArray();
            return array;
        }

        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
            }
        }

        private static double yourAverage()
        {
            int a;                                         // This will be the number of values in the users array
            Console.WriteLine("Input the number of values in your array");
            a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];
            int i;

            for (i = 0; i < a; i++)
            {
                Console.WriteLine(" input an integer between the value of 0 and 100 in the array", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sum = 0.0;
            for (i = 0; i < a; i++)
            {
                sum += array[i];
            }

            double yourAvg = sum / a;

            Console.WriteLine("The average test score was: " + yourAvg);

            if (yourAvg >= 90)
            {
                Console.WriteLine("The average grade was an A");
            }

            else if (yourAvg >= 80)
            {
                Console.WriteLine("The average grade was a B");
            }
            else if (yourAvg >= 70)
            {
                Console.WriteLine("The average grade was a C");
            }
            else if (yourAvg >= 60)
            {
                Console.WriteLine("The average score was a D");
            }
            else
            {
                Console.WriteLine("The Average score was an F");
            }
            return yourAvg;
        }

        private static int avgScores()
        {
            var avgArray = 0;
            avgArray = sumArray() / 10;         /* Since sumArray always has 10 values, we can just divide by 10. 
                                                   else we can divide by array.length*/
            Console.WriteLine(avgArray);

            if (avgArray >= 90)
            {
                Console.WriteLine("The average grade was an A");
            }

            else if (avgArray >= 80)
            {
                Console.WriteLine("The average grade was a B");
            }
            else if (avgArray >= 70)
            {
                Console.WriteLine("The average grade was a C");
            }
            else if (avgArray >= 60)
            {
                Console.WriteLine("The average score was a D");
            }
            else
            {
                Console.WriteLine("The Average score was an F");
            }

            return avgArray;
        }

        private static int sumArray()
        {
            int[] array = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" input an integer between the value of 0 and 100 in the array", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (i = 0; i < 10; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(string.Join(" ", array)); // This is to show the array formatted properly
            Console.WriteLine("The sum of this array is: " + sum);

            return sum; 
        }
    }
}
