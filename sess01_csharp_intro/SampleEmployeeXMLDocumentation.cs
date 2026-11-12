namespace sess01_csharp_intro
{
    /// <summary>
    /// Represents an Employee with an ID, name, and binary gender.
    /// </summary>
    public class SampleEmployeeXMLDocumentation
    {
        // Fields
        /// <summary>
        /// An unsigned integer denoting the employee's unique ID.
        /// </summary>
        private uint _empID;

        /// <summary>
        /// String field to hold the employee's name
        /// </summary>
        private string _empName;

        /// <summary>
        /// Character field to hold the employee's binary gender
        /// </summary>
        /// <remarks>The gender is 'M' or 'm' for Male and 'F' or 'f' for female.</remarks>
        private char _gender;

        // Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/>
        /// This constructor sets default values for the employee's id, name and gender
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; // Same as this._empName = "";
            this._gender = 'M'; 
        }

        /// <summary>
        /// Initialises a new instance of the < see cref="SampleEmployeeXMLDocumentation"/>
        /// with the specified values for the employee's id, name and gender 
        /// </summary>
        /// <param name="empid">The employee's unique ID number</param>
        /// <param name="name">The employee's name</param>
        /// <param name="gender">The employee's gender ('M' or 'm' for Male and 'F' or 'f' for female).</param>
        public SampleEmployeeXMLDocumentation(uint empid, string name, char gender)
        {
            this._empID= empid;
            this._empName= name;
            this._gender= gender;            
        }

        /// <summary>
        /// Retrieves/gets the employee's ID
        /// </summary>
        /// <returns>The employee's ID</returns>
        public uint GetID() { return this._empID; }

        public void SetID(uint empID) { this._empID = empID; }

        /// <summary>
        /// Retrieves/gets the employee's name
        /// </summary>
        /// <returns>The employee's name</returns>
        public string GetName() { return this._empName; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name) { this._empName = name; }

        /// <summary>
        /// Retrieves/gets the employee's gender
        /// </summary>
        /// <returns>The employee's gender</returns>
        public char GetGender() { return this._gender; }

        /// <summary>
        /// Assigns/sets the employee's binary gender
        /// </summary>
        /// <param name="gender">The employee's gender 'M' or 'm' for Male and 'F' or 'f' for female.</param>
        public void SetGender(char gender) { this._gender = gender; }


        /// <summary>
        /// Returns a string representation of the employee's details.
        /// </summary>
        /// <returns>A string containing the employee's id, name, and gender.</returns>
        public override string ToString()
        {
            return $"Employee Details" +
                $"\n--------------------------------------------------" +
                $"\nID: {this.GetID()}" +
                $"\nName: {this.GetName()}" +
                $"\nGender: {(this.GetGender() =='M' ||this.GetGender() =='m'? "Male": "Female" )}"+
                $"\n--------------------------------------------------";
        }
    }
}
