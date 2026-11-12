using System;
using System.Collections.Generic;
using System.Text;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Demonstrates checked and unchecked arithmetic using the byte data type.
    /// </summary>
    /// <remarks>
    /// A byte can store values from 0 to 255 inclusive.
    /// Checked arithmetic detects intergral (integer) overflow and throws an
    /// overflow exception. Unchecked arithmetic allows intergral overflow to 
    /// wrap around when the operation is performed in an unchecked context.
    /// </remarks>
    public class CheckedUncheckedDemo
    {
        /// <summary>
        /// Demonstrates checked addition when the result exceeds the
        /// maximum value of the byte data type.
        /// </summary>
        private static void DemonstrateCheckedAddition()
        {
            Console.WriteLine("1. Checked addition");

            byte number = 250;
            byte increment = 10;

            try
            {
                // The result, 260, is outside the permitted byte range.
                // The checked context causes an OverflowException.
                byte result = checked((byte)(number + increment));

                Console.WriteLine($"Result: {result}");
            }
            catch (OverflowException ex)
            {
                // Handle the arithmetic overflow without terminating
                // the application.
                Console.WriteLine(
                    $"Overflow detected: {ex.Message}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates unchecked addition when the result exceeds
        /// the maximum value of the byte data type.
        /// </summary>
        private static void DemonstrateUncheckedAddition()
        {
            Console.WriteLine("2. Unchecked addition");

            byte number = 250;
            byte increment = 10;

            // Unchecked conversion discards the bits outside the
            // eight-bit byte range, producing 4.
            byte result = unchecked((byte)(number + increment));

            Console.WriteLine($"{number} + {increment} = {result}");
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates checked subtraction when the result is negative
        /// and therefore cannot be represented by a byte.
        /// </summary>
        private static void DemonstrateCheckedSubtraction()
        {
            Console.WriteLine("3. Checked subtraction");

            byte number = 5;
            byte decrement = 10;

            try
            {
                // The mathematical result is -5, which is outside
                // the permitted byte range of 0 to 255.
                byte result = checked((byte)(number - decrement));

                Console.WriteLine($"Result: {result}");
            }
            catch (OverflowException ex)
            {
                // Report the error and allow the remaining examples
                // to execute.
                Console.WriteLine(
                    $"Overflow detected: {ex.Message}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates unchecked subtraction when the result is
        /// negative and cannot be represented by a byte.
        /// </summary>
        private static void DemonstrateUncheckedSubtraction()
        {
            Console.WriteLine("4. Unchecked subtraction");

            byte number = 5;
            byte decrement = 10;

            // The intermediate subtraction is performed as an int.
            // The unchecked conversion wraps -5 to the byte value 251.
            byte result = unchecked((byte)(number - decrement));

            Console.WriteLine($"{number} - {decrement} = {result}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CHECKED AND UNCHECKED ARITHMETIC");
            Console.WriteLine(new string('-',60));
            Console.WriteLine();            

            DemonstrateCheckedAddition();
            DemonstrateUncheckedAddition();
            DemonstrateCheckedSubtraction();
            DemonstrateUncheckedSubtraction();
            
            Console.WriteLine(new string('-',60));
            Console.WriteLine();
        }

    }
}
