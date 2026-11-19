namespace sess09_delegates_events_and_collections;

/// <summary>
/// represents a multicast delegate that references methods performing arithmetic calculations on two integer values.
/// </summary>
/// <param name="num1">The first integer value used in the calculation.</param>
/// <param name="num2">The second integer value used in the calculation.</param>
public delegate void MulticastCalc(int num1, int num2);

/// <summary>
/// Demostrates the use of multicast delegates to perform multiple arithmetic operations using a single delegate instance
/// </summary>
public class MulticastDelegate
{
    /// <summary>
    /// Calculates and the displays the sum of two integer values
    /// </summary>
    /// <param name="num1">The first integer value </param>
    /// <param name="num2">The second integer value</param>
    static void AddNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

    }

    /// <summary>
    /// Calculates and the displays the sub of two integer values
    /// </summary>
    /// <param name="num1">The first integer value </param>
    /// <param name="num2">The second integer value</param>
    static void SubNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

    }
    /// <summary>
    /// Calculates and the displays the mul of two integer values
    /// </summary>
    /// <param name="num1">The first integer value </param>
    /// <param name="num2">The second integer value</param>
    static void MulNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

    }
    /// <summary>
    /// Calculates and the displays the div of two integer values
    /// </summary>
    /// <param name="num1">The first integer value </param>
    /// <param name="num2">The second integer value</param>
    static void DivNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

    }
        /// <summary>
    /// Calculates and the displays the remainder of two integer values
    /// </summary>
    /// <param name="num1">The first integer value </param>
    /// <param name="num2">The second integer value</param>
    static void GetRemainder(int num1, int num2)
    {
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

    }
    static void Main(string[] args)
    {
        // Declare and instantiate the multicast delegate
        MulticastCalc mathOperation = new MulticastCalc(AddNums); // Pass the 1st method reference
        // Add the other class method references
        mathOperation += MulNums;
        mathOperation += SubNums;
        mathOperation += DivNums;
        mathOperation += GetRemainder;

        // Prompt the user for the numbers to be used in the calculation
        Console.WriteLine($"Please enter the first number to be used in the calculation");
        int num1 = int.Parse(Console.ReadLine() );
        Console.WriteLine($"Please enter the second number to be used in the calculation");
        int num2 = int.Parse(Console.ReadLine() );

        // Perform and display the results of the various arithmetic operations
        mathOperation(num1, num2);

        //rempve the Multiply and Remainder operations
        Console.WriteLine($"Removing the Multiply and Remainder methods ...");
        mathOperation -= MulNums;
        mathOperation -= GetRemainder;

        // perform and display  the results of the various arithmetic operations
        mathOperation(num1, num2);

    }
}
