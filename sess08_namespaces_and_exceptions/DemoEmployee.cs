namespace sess08_namespaces_and_exceptions;

public class DemoEmployee
{
    static void Main()
    {
        // declare and instatiate an Employee object
        Employee emp1 = new Employee();
        // prompt the user for the employee's details
        Console.WriteLine("Please enter employees's name: ");
        emp1.Name = Console.ReadLine();
        Console.WriteLine($@"Please enter {emp1.Name}'s ID: ");
        emp1.ID = uint.Parse(Console.ReadLine());
        Console.WriteLine($@"Please enter {emp1.Name}'s gender: ");
        emp1.Gender = char.Parse(Console.ReadLine());
        Console.WriteLine($@"Please enter {emp1.Name}'s nationality: ");
        emp1.Nationality = Console.ReadLine();

        // declare and instatiate a salaryDetails object
        SalaryDetails empSalary = new SalaryDetails();
        // prompt the user for the employee's salary details
        Console.WriteLine($@"Please enter {emp1.Name}'s salary amount: ");
        empSalary.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

        //display the employee's details and their salary details
        Console.WriteLine(emp1 + "" + empSalary);
        Console.WriteLine($@"{emp1.Name}'s salary: {empSalary.EmployeeSalary}");
    }
}
