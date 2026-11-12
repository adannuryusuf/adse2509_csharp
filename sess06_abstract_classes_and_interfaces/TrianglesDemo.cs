using System;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Demonstrates the creation and use of different triangle types.
    /// Creates instances of <see cref="RightAngledTriangle"/> and
    /// <see cref="ScaleneTriangle"/>, calculates their areas and perimeters,
    /// and displays their dimensions
    /// </summary>
    public class TrianglesDemo
    {
        /// <summary>
        /// Prompts the user to enter a positive integer dimension and validates
        /// the input before returning it as a byte.
        /// Repeatedly prompts the user until a valid value between 1 and 255
        /// is supplied.
        /// </summary>
        /// <param name="dimensionName">The name of the dimension being requested,
        /// such as height or base.</param>
        /// <returns>A valid positive dimension represented as a byte.</returns>
        private static byte GetPositiveDimensions(String dimensionName)
        {
            byte dimension;

            // Continue prompting the user until a valid positive integer is entered
            while(true)
            {
                Console.Write($"Enter the triangle's {dimensionName} (1 - 255):");

                string? input = Console.ReadLine();

                // Validate that the input is a +ve integer within the byte range
                if (byte.TryParse(input, out dimension) && dimension > 0)
                {
                    return dimension;
                }

                // Inform the user that the supplied value is invalid
                Console.WriteLine($"Invalide {dimensionName}. Please enter a positive whole" +
                    $"number between 1 - 255.\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new string('=',60));
            Console.WriteLine("             TRIANGLES DEMONSTRATION");
            Console.WriteLine(new string('=',60));

            // Obtain valid dimensions from the user for the right-angled triangle
            byte height = GetPositiveDimensions("height");
            byte @base = GetPositiveDimensions("base");

            // Create a right-angled triangle using dimensions supplied by the user.
            RightAngledTriangle tr1 = new RightAngledTriangle(height, @base);

            // Create a Scalene triangle using hard-coded values. The values used 
            // satisfy the triangle inequality theorem
            ScaleneTriangle sc1 = new ScaleneTriangle(5, 6, 7);

            // Display the dimensions and calculated properties of the right-angled triangle.
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("             RIGHT-ANGLED TRIANGLE");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(tr1);

            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("             SCALENE TRIANGLE");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(sc1);
        }
    }
}
