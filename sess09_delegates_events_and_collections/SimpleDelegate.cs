namespace sess09_delegates_events_and_collections;
/// <summary>
/// Defines a delegate that references methods performing
/// arithmetic calculations on two integer values.
/// </summary>
/// <param name="num1">The first integer operand.</param>
/// <param name="num2">The second integer operand.</param>
/// <returns>
/// An integer reps the result of the calculation
/// </returns>
public delegate int Calculation(int num1, int num2);
/// <summary>
/// Demonstates the use of delegates to reference and invoke static methods that perform basic arithmetic calculations, including addition, subtraction, multiplication, and division.
/// </summary>
public class SimpleDelegate
{
    /// <summary>
    /// Add two integers and returns their sum
    /// </summary>
    /// <param name="num1 The first integer value"></param>
    /// <param name="num2"> The second integer value</param>
    /// <returns>the sum of the two integers values</returns>
    static int AddNums(int num1, int num2){return num1 + num2;}
    static int SubNums(int num1, int num2){return num1 - num2;}
    static int MulNums(int num1, int num2){return num1 * num2;}
    static int DivNums(int num1, int num2){return num1 / num2;}
    static int GetRemainder(int num1, int num2){return num1 % num2;}
    static void Main(string[] args)
    {
        // declare and instantiate the values used in the program
        int val1 = 5, val2 = 6;

        // declare a delegates for the class/static methods above
        Calculation addDelegate, prodDelegate, subDelegate, divDelegate, remainderDelegate;

        // instantiate the above delegates objects
        addDelegate = new Calculation(AddNums);
        subDelegate = new Calculation(SubNums);
        prodDelegate = new Calculation(MulNums);
        divDelegate = new Calculation(DivNums);
        remainderDelegate = new Calculation(GetRemainder);

        //invoke the corresponding methods using their delegates
        Console.WriteLine($"The sum of {val1} + {val2} = {addDelegate(val1, val2)}");
        Console.WriteLine($"The difference of {val1} - {val2} = {subDelegate(val1, val2)}");
        Console.WriteLine($"The product of {val1} * {val2} = {prodDelegate(val1, val2)}");
        Console.WriteLine($"The quotient of {val1} / {val2} = {divDelegate(val1, val2)}");
        Console.WriteLine($"The remainder of {val1} % {val2} = {remainderDelegate(val1, val2)}");
    }
}
