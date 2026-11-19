namespace sess10_generics_and_iterators;
/// <summary>
/// reps a <see cref="Person"/> object with details such as names firtdate gender email and nationality 
/// </summary>
public class Person
{
    //=======================================================================
    // PERSON PROPERTIES
    //=======================================================================
    /// <summary>
    /// Gets or sets the person's full name.
    /// </summary>
    public string Names { get; set; }

    /// <summary>
    /// Gets or sets the person's date of birth.
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the person's gender.
    /// </summary>
    public char Gender { get; set; }

    /// <summary>
    /// Gets or sets the person's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the person's nationality.
    /// </summary>
    public string Nationality { get; set; }


    //=======================================================================
    // PERSON CONSTRUCTORS
    //=======================================================================
    public Person()
    {
        this.Names = string.Empty;
        this.BirthDate = DateTime.MinValue;
        this.Gender = 'M';
        this.Email = string.Empty;
        this.Nationality = "";
    }

    public Person(string names, DateTime dob, char gender, string email, string nationality)
    {
        this.Names = string.Empty;
        this.BirthDate = DateTime.MinValue;
        this.Gender = 'M';
        this.Email = string.Empty;
        this.Nationality = "";
    }

    /// <summary>
    /// Returns a formatted string representation of the person's  details.
    /// </summary>
    /// <returns>
    /// A human-readable representation of the person's name, birthdate, gender, email, and
    /// nationality.
    /// </returns>

    public override string ToString()
    {
        return $"Person's Details" +
            $"\n" + new string('-', 55) +
            $"\nNames: {this.Names}" +
            $"\nDate of birth: {this.BirthDate}" +
            $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
            $"\nEmail: {this.Email}" +
            $"\nNationality: {this.Nationality}" +
            $"\n" + new string('-', 55);
    }

}

