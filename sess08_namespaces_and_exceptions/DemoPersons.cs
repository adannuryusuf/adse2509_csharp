using sess04_classes_and_methods;
using System;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program to illustrate how to work with classes from different namespaces.
    /// </summary>
    public class DemoPersons
    {
        static void Main(string[] args)
        {
            SimplePerson buddy1 = new SimplePerson();
            // You can prompt the user for the values, but for now we'll just hard-code them.
            buddy1.SetNames("Yukti Velanel");
            buddy1.SetGender("Female");
            buddy1.SetBirthDate(Convert.ToDateTime("1990-12-12"));
            buddy1.SetNationality("Indian");

            // Display buddy's details
            Console.WriteLine(buddy1);

            simplerPerson buddy2 = new SimplerPerson();
            Console.WriteLine();
            buddy2.Names = "Ruth Boaz";
            buddy2.Gender = 'F';
            buddy2.BirthDate = new DateTime(1995, 12, 12);
            buddy2.Nationality = "American";
            Console.WriteLine(buddy2);
        }
    }
}

