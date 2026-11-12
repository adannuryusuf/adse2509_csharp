using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program that uses two nested loops and a decision construct (if-else)
    /// to produce a diamond-shaped star pattern
    /// </summary>
    public class StarPattern
    {
        /// <summary>
        /// Uses two nested loops and an if-else decision construct to display
        /// diamond-shaped star pattern.
        /// </summary>
        /// <param name="args">command line string arguments</param>
        static void Main(string[] args)
        {
            int rows = 5; // Number of rows in upper half

            // Outer loop controls the total number of rows.
            // The pattern contains an upper and a lower half.
            for (int i = 1; i <= (2 * rows - 1); i++)
            {
                // Determines whether the current row belongs
                // to the upper or lower half of the diamond.
                int stars;

                if (i <= rows)
                {
                    // Upper half: increase the number of stars.
                    stars = i;
                }
                else
                {
                    // Lower half: decrease the number of stars.
                    stars = (2 * rows) - i;
                }

                // Prints leading spaces to centre the stars.
                for (int j = 1; j <= (rows - stars); j++)
                {
                    Console.Write(" ");
                }

                // Prints the required number of stars.
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("* ");

                }

                // Moves the cursor to the next line.
                Console.WriteLine();
            }
        }
    }
}
