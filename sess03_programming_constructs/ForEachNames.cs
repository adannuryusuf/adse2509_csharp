using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program to demostrate displaying an array of names using the for...each loop.
    /// </summary>
    public class ForEachNames
    {
        static void Main(string[] args)
        {
            // Declare an array of student names
            string[] studentNames = { "Mathew", "Alex", "Teka", "Pascal", "Miranda", "Justin" };

            // Display the names of the students present in class.
            Console.WriteLine("The names of the students present in class today are:");
            uint n = 1;
            foreach (string name in studentNames)
                Console.WriteLine($"Student {n++:d2}: {name}");
        }
    }
}
