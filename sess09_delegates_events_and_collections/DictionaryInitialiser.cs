namespace sess09_delegates_events_and_collections;
/// <summary>
/// program to demonstrate the generic dictionary class
/// </summary>
public class DictionaryInitialiser
{
    static void Main(string[] args)
    {
        // declare and initialise a generic dictionary of employees
        Dictionary<uint, Employee> empDictionary = new Dictionary<uint, Employee>()
        {
            {1,
                new Employee
                {
                    EmpID = 1005,
                    Name = "Clarion Madiba",
                    BirthDate = Convert.ToDateTime("03-02-1989"),
                    Gender = 'F',
                    Nationality = "Canadian"
                }
            },
            {2,
                new Employee
                {
                    EmpID = 1007,
                    Name = "James Anderson",
                    BirthDate = Convert.ToDateTime("02-01-2001"),
                    Gender = 'M',
                    Nationality = "French"
                }
            },
            {3,
                new Employee
                {
                    EmpID = 1008,
                    Name = "Emily Bernard",
                    BirthDate = Convert.ToDateTime("03-04-1999"),
                    Gender = 'F',
                    Nationality = "Nigerian"
                }
            },
        };
        // add a new employee
        empDictionary.Add(4, new Employee
        {
            EmpID = 1009,
            Name = "John Mathiukure",
            BirthDate = Convert.ToDateTime("08-08-1988"),
            Gender = 'M',
            Nationality = "Kenyan"
        });
        empDictionary.Add(5, new Employee
        {
            EmpID = 1010,
            Name = "Abigail Mueni",
            BirthDate = Convert.ToDateTime("25-04-1996"),
            Gender = 'F',
            Nationality = "Kenyan"
        });

        //display the number of keys in the employee dictionary and their values
        Console.WriteLine($"The employee dictionary has {empDictionary.Count} keys and they are:\n");

    }
}
