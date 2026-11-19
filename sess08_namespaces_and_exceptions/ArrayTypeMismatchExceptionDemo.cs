namespace sess08_namespaces_and_exceptions;
/// <summary>
/// program to demonstrate <see cref="ArrayMismatchException"/>
/// </summary>
public class ArrayTypeMismatchExceptionDemo
{
    static void Main(string[] args)
    {
        // declare and initialize an array of student names
        string[] studentNames = { "Chandni", "Tesfai", "Abigail" };
        // declare and initialize an array of student admission numbers
        uint[] admissionNums = { 1001, 1002, 1003 };
        // declare and initialize an array of student tuition fees
        double[] tuitionFee = { 5000.5, 4500.5, 5500.45 };
        // declare and instantiate a float array of caution fee/money
        float[] cautionFee = new float[3];

        try
        {
            // set the caution amount to the sems tuition fee
            for (int n = 0; n < studentNames.Length; n++)
            {
                tuitionFee.CopyTo(cautionFee, n); // will cause an exception (double to float)
            }
        }
        catch (ArrayTypeMismatchException atme)
        {
            Console.WriteLine($"What went wrong: {atme.Message}" +
            $"\nError: {atme}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"The exception " +
            $"{e.GetType().ToString().Replace("System.", "")} occured.");
        }
        finally
        {
            Console.WriteLine("The program has completed execution.");
        }

    }
}
