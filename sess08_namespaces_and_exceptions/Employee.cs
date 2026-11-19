
namespace sess08_namespaces_and_exceptions;

/// <summary>
/// Represents an instance of the <see cref="Employee"/> class with details derived from the
/// <see cref="SimplerPerson"/> class and the employee's ID.
/// </summary>
public class Employee
{
    //=============================================================
    // PROPERTIES
    //=============================================================

    // Stores the employee's name.
    public string Name { get; set; }

    // Stores the employee's identification number.
    public uint EmpID { get; set; }

    // Stores the employee's date of birth.
    public DateTime BirthDate { get; set; }

    // Stores the employee's gender.
    public char Gender { get; set; }

    // Stores the employee's nationality.
    public string Nationality { get; set; }


    //=============================================================
    // OVERRIDDEN METHOD(S)
    //=============================================================

    /// <summary>
    /// Returns a formatted string representation of the employee's details.
    /// </summary>
    /// <returns>
    /// A human-readable representation of the employee's name, birthdate, gender and
    /// nationality.
    /// </returns>
    public override string ToString()
    {
        return $"Person's Details" +
            $"\n" + new string('-', 55) +
            $"\nNames: {this.Name}" +
            $"\nEmployee ID: {this.EmpID}" +
            $"\nDate of birth: {this.BirthDate}" +
            $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
            $"\nNationality: {this.Nationality}" +
            $"\n" + new string('-', 55);
    }
}

namespace Salary
{
    class SalaryDetails
    {
        public double EmployeeSalary { get; set; }

        public override string ToString()
        {
            return $"\nSalary Amount: Kes. {this.EmployeeSalary}" +
                $"\n" + new string('-', 55);
        }
    }
}
