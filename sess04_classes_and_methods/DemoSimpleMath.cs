using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate the static and overloaded methods in the <see cref="SimpleMath"/> class.
    /// </summary>
    public class DemoSimpleMath
    {
       static void Main(string[] args)
        {
            // Variables to be used in the program
            int firstNum, secondNum;
            long total, product;
            int[] scores = { 45, 35, 55, 65, 85, 45 };

            // Prompt the user for the numbers to be used in the calculation(s)
            Console.WriteLine("Please enter the first number to be used in the calculation(s) -> ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number to be used in the calculation(s) -> ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number to be used in the calculation(s) -> ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            // Calculate and display the result of various arithmetic operations with the above variables
            total = SimpleMath.AddNums(firstNum, secondNum);
            product = new SimpleMath().MultiplyNums(firstNum, secondNum);
            Console.WriteLine($"The sum of {firstNum} + {secondNum} = {total}");
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = {SimpleMath.AddNums(firstNum,secondNum,thirdNum)}");
            Console.WriteLine($"The product of {firstNum} x {secondNum} = {product}");
            Console.WriteLine($"The difference between {firstNum} - {secondNum} = {SimpleMath.SubtractNums(firstNum,secondNum)}");
            Console.WriteLine($"The remainder of dividing {firstNum} % {secondNum} = {SimpleMath.GetModulus(firstNum,secondNum)}");
            Console.WriteLine($"The exponent of {firstNum} raised to {secondNum} = {SimpleMath.GetExponent(firstNum,secondNum)}");
            Console.WriteLine($"The sum of {string.Join(", ",scores)} is: {SimpleMath.AddNums(scores)}");
        }
    }
}
