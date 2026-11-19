namespace sess10_generics_and_iterators;
/// <summary>
/// Represents a <see cref="Student"/> with basic details like student number, names, birthdate, gender, email, course, current sem and nationality
/// </summary>
public class Student : Person
{
    //=======================================================================
    // STUDENT PROPERTIES
    //=======================================================================
    /// <summary>
    /// Gets or sets the students number
    /// </summary>
    public string StudentNo { get; set; }
    /// <summary>
    /// gets or sets the students course
    /// </summary>

    public string Course { get; set; }
    /// <summary>
    /// gets or sets the students current sem
    /// </summary>
    public byte CurrentSem { get; set; }


    //=======================================================================
    // STUDENT CONSTRUCTORS
    //=======================================================================
    public Student():base()
    {
        this.StudentNo = string.Empty;
        this.Course = "";
        this.CurrentSem = 1;
    }

    /// <summary>
    /// initialises a <see cref="Student"/> object with the specified values
    /// </summary>
    /// <param name="names">The students names</param>
    /// <param name="dob">The students date of birth</param>
    /// <param name="gender">The students gender</param>
    /// <param name="email">The students email</param>
    /// <param name="nationality">The students nationality</param>
    /// <param name="studNo">The students student no</param>
    /// <param name="course">The students course</param>
    /// <param name="currSem">The students current sem</param>
    public Student (string names, DateTime dob, char gender, string email, string nationality, string studNo, string course, byte currSem):base(names,dob,gender,email,nationality)
    {
        this.StudentNo = StudentNo;
        this.Course = course;
        this.CurrentSem = currSem;
    }
    //=======================================================================
    // STUDENT OVERRIDDEN METHOD(S)
    //=======================================================================
    /// <summary>
    /// Returns a formatted string representation of the student's  details.
    /// </summary>
    /// <returns>
    /// A human-readable representation of the student's name, student id, birthdate, gender, email, course, current sem and 
    /// nationality.
    /// </returns>
    public override string ToString()
    {
        return $"Person's Details" +
            $"\n" + new string('-', 55) +
            $"\nStudent Number: {this.StudentNo}" +
            $"\nNames: {this.Names}" +
            $"\nDate of birth: {this.BirthDate}" +
            $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
            $"\nEmail: {this.Email}" +
            $"\nCourse: {this.Course}" +
            $"\nCurrent Semester: {this.CurrentSem}" +
            $"\nNationality: {this.Nationality}" +
            $"\n" + new string('-', 55);
    

}
}


