using System;
using System.Collections.Generic;
using System.Text;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program to display the first ten integers, their sum and average using 
    /// a do...while loop.
    /// </summary>
    public class FirstTenDoWhileLoop
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float average;
            int n = 1; //Looping variable
            do
            {
                if (n < 10)
                {
                    Console.Write(n + ", ");
                }
                else
                {
                    Console.Write(n + ".\n");
                }
                sum += n;
                n++;
            } while (n <= 10);
            average = sum / (float)10;//Compute mean/average
                                      //Display the results
            Console.Write($"The sum of the first ten integers is "
                    + sum + $" and their average is {average:f2}\n");
        }
    }
}
