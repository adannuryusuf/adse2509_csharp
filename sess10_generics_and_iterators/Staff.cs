
namespace sess10_generics_and_iterators;

/// <summary>
/// Represents a <see cref="Staff"/> with basic details like StaffID, Names, Birthdate,
/// Gender (binary), employment date, designation, phone number, email, and Nationality
/// </summary>
public class Staff : Person
{
    //=============================================================================
    // STAFF PROPERTIES
    //=============================================================================
    /// <summary>
    /// gets or sets the staff members staff id
    /// </summary>
    public string StaffID { get; set; }
    
    /// <summary>
    /// gets or sets the staff members employment date
    /// </summary>
    public DateTime EmploymentDate { get; set; }
    
    /// <summary>
    /// gets or sets the staff members designation
    /// </summary>
    public string Designation { get; set; }

    /// <summary>
    /// gets or sets the staff members phone number
    /// </summary>
    public string PhoneNo { get; set; }

    //=============================================================================
    // STAFF CONSTRUCTORS
    //=============================================================================
    
    /// <summary>
    /// initialises a <see cref="Staff"/> object with default values
    /// </summary>
    public Staff():base()
    {
        this.StaffID = "";
        this.EmploymentDate = new DateTime(); // current date
        this.Designation = string.Empty;
        this.PhoneNo= string.Empty;
    }
    
    /// <summary>
    /// inititalises a <see cref="Staff"/> object with specified values
    /// </summary>
    /// <param name="names">The staff members names</param>
    /// <param name="dob">The staff members date of birth</param>
    /// <param name="gender">The staff members gendr</param>
    /// <param name="email">The staff members email</param>
    /// <param name="nationality">The staff members nationality</param>
    /// <param name="staffID">The staff members staff id</param>
    /// <param name="employmentDate">The staff members employment date</param>
    /// <param name="designation">The staff members designation</param>
    /// <param name="phoneNo">The staff members phone number</param>
    public Staff(string names, DateTime dob, char gender, string email, string nationality,
    string staffID,DateTime employmentDate, string designation, string phoneNo) :
    base(names, dob, gender, email, nationality)
    {
        this.StaffID = staffID;
        this.EmploymentDate = employmentDate;
        this.Designation = designation;
        this.PhoneNo = phoneNo;
    }

    //=============================================================================
    // STAFF OVERRIDDEN METHOD(S)
    //=============================================================================
    /// <summary>
    /// Returns a formatted string representation of the staff's  details.
    /// </summary>
    /// <returns>
    /// A human-readable representation of the staff's name, staff id birthdate, gender, email, employment date, designation, phone number and 
    /// nationality.
    /// </returns>

    public override string ToString()
    {
        return $"Person's Details" +
            $"\n" + new string('-', 55) +
            $"\nStaff Number: {this.StaffID}" +
            $"\nNames: {this.Names}" +
            $"\nDate of birth: {this.BirthDate}" +
            $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
            $"\nEmail: {this.Email}" +
            $"\nEmployment Date: {this.EmploymentDate}" +
            $"\nDesignation: {this.Designation}" +
            $"\nPhone Number: {this.PhoneNo}" +
            $"\nNationality: {this.Nationality}" +
            $"\n" + new string('-', 55);
    

}
}
