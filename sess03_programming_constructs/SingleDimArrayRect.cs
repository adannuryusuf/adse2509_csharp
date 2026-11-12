using sess04_classes_and_methods;
using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program to demonstrate the use of reference/object types in single dimension arrays.
    /// </summary>
    public class SingleDimArrayRect
    {
        static void Main(string[] args)
        {
            // Declare an array of Rectangles
            Rect[] rectangles;

            // Prompt the user for the number of rectangle they'd like to create
            Console.WriteLine("How many rectangles would you like to create?");
            uint numOfRects = Convert.ToUInt32(Console.ReadLine());

            // Initialise the rectangles array with the number of rectangles the user wishes to create
            rectangles = new Rect[numOfRects];

            uint len = 0, wid = 0;
            // Get the dimensions for the rectangles from the user
            for (uint n = 0; n < numOfRects; n++)
            {
                Console.WriteLine($"Please enter the length of rectangle {n + 1}:");
                len = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Please enter the width of rectangle {n + 1}:");
                wid = Convert.ToUInt32(Console.ReadLine());
                rectangles[n] = new Rect(len, wid);  // Instantiate the rectangle
                // Display the rectangle's details
                Console.WriteLine(rectangles[n].ToString());
            }
        }
    }
}
