using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Class to demonstrate the use of static methods and method overloading
    /// </summary>
    public class SimpleMath
    {
        /// <summary>
        /// Adds two integers and returns their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the addition.</param>
        /// <param name="num2">Second number to be used in the addition.</param>
        /// <returns>The sum of the two integers passed in as parameters</returns>
        public static long AddNums(int num1, int num2) { return num1 + num2; }

        /// <summary>
        /// Adds three integers and returns their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the addition.</param>
        /// <param name="num2">Second number to be used in the addition.</param>
        /// <param name="num3">Third number to be used in the addition.</param>
        /// <returns>The sum of the three integers passed in as parameters</returns>
        public static long AddNums(int num1, int num2, int num3) { return num1 + num2 + num3; }

        /// <summary>
        /// Subtracts two integers and returns their difference as an integer value
        /// </summary>
        /// <param name="num1">First number to be used in the subtraction.</param>
        /// <param name="num2">Second number to be used in the subtraction.</param>
        /// <returns>The difference of the two integers passed in as parameters</returns>
        public static int SubtractNums(int num1, int num2) { return num1 - num2; }

        /// <summary>
        /// Multiplies two integers and returns their product as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the multiplication.</param>
        /// <param name="num2">Second number to be used in the multiplication.</param>
        /// <returns>The product of the two integers passed in as parameters</returns>
        public long MultiplyNums(int num1, int num2) { return num1 * num2; }

        /// <summary>
        /// Divides two integers and returns their remainder as an integer value
        /// </summary>
        /// <param name="num1">First number to be used in the division.</param>
        /// <param name="num2">Second number to be used in the division.</param>
        /// <returns>The remainder of dividing the two integers passed in as parameters</returns>
        public static int GetModulus(int num1, int num2) { return num1 % num2; }

        /// <summary>
        /// Calculates the result of raising the first number to the power of the second number.
        /// </summary>
        /// <param name="num1">The base number to be used in the exponentiation.</param>
        /// <param name="num2">The exponent to which the base is to be raised in the exponentiation.</param>
        /// <returns>The result of the exponentiation as a <see cref="float"/>.</returns>
        public static float GetExponent(int num1, int num2) { return (float)Math.Pow(num1, num2); }

        /// <summary>
        /// Add the values in an array of integers and returns their sum.
        /// </summary>
        /// <param name="nums">An array of integers</param>
        /// <returns>The sum of the integer  values in the array.</returns>
        public static long AddNums(params int[] nums)
        {
            //long sum = 0;
            //foreach (int num in nums)
            //{
            //    sum += num;
            //}
            //return sum;
            return nums.Sum();
        }
    }
}
