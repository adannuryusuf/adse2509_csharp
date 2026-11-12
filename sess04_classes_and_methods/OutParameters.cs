using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Demonstrates the use of the 'out' keyword in C# to pass an argument by
    /// reference, allowing a method to initialise and assign a value to a variable
    /// declared in the calling method.
    /// </summary>
    public class OutParameters
    {
        /// <summary>
        /// Calculates the depreciation of an object based on an initial
        /// value of 40,000 and a depreciation rate of 20 per cent.
        /// </summary>
        /// <param name="value">
        /// An output parameter that is assigned an initial value of 40,000.
        /// The assigned value is made available to the calling method.
        /// </param>
        /// <remarks>
        /// The out keyword allows the method to assign a value to the
        /// parameter without requiring it to be initialised beforehand.
        /// The method calculates the depreciation amount and the reduced
        /// value of the object, then displays the results.
        /// </remarks>
        static void Depreciation(out int value)
        {
            // Assign the initial value of the object.
            value = 40000;

            // Display the initial value of the object.
            Console.WriteLine($"Initial value of object: {value}");

            // Calculate the depreciation amount at a rate of 20%
            int dep = value * 20 / 100;

            // Calculate the reduced value after depreciation
            int amount = value - dep;

            // Display the depreciation amount and the final value of the object
            Console.WriteLine($"Depreciation amount: {dep}" +
                $"\nReduced value after depreciation: {amount}");
        }

        static void Main()
        {
            // Declare an integer variable without initialising it.
            int value;

            // Invoke the 'Depreciation()' method, passing 'value' declared above as an 'out' parameter.
            Depreciation(out value);
        }
    }
}
