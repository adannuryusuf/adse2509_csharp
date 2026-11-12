using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Represents a person and stores their basic personal details including
    /// their names, date of birth, binary gender and nationality.
    /// </summary>
    public class SimplePerson
    {
        /// <summary>
        /// Stores the person's full names
        /// </summary>
        protected string names;

        /// <summary>
        /// Stores the person's date of birth
        /// </summary>
        protected DateTime birthDate;

        /// <summary>
        /// Stores the person's binary gender (male or female)
        /// </summary>
        protected string gender;

        /// <summary>
        /// Stores the person's nationality
        /// </summary>
        protected string nationality;

        /// <summary>
        /// Initialises a new instance of the SimplePerson class.
        /// Assigns default values to all instance fields.
        /// </summary>
        public SimplePerson()
        {
            // Initialise string fields with empty strings.
            this.names = string.Empty;
            this.birthDate = DateTime.MinValue;
            this.gender = string.Empty;
            this.nationality = string.Empty;
        }

        /// <summary>
        /// Retrieves the person's full names.
        /// </summary>
        /// <returns>
        /// A string containing the person's full names.
        /// </returns>
        public string GetNames()
        {
            return this.names;
        }

        /// <summary>
        /// Assigns the specified full names to the person.
        /// </summary>
        /// <param name="names">
        /// The full names to be assigned to the person.
        /// </param>
        public void SetNames(string names)
        {
            this.names = names;
        }

        /// <summary>
        /// Retrieves the person's date of birth.
        /// </summary>
        /// <returns>
        /// A DateTime value representing the person's date of birth.
        /// </returns>
        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        /// <summary>
        /// Assigns the specified date of birth to the person.
        /// </summary>
        /// <param name="birthDate">
        /// The date of birth to be assigned to the person.
        /// </param>
        public void SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        /// <summary>
        /// Retrieves the person's gender.
        /// </summary>
        /// <returns>
        /// A string representing the person's gender.
        /// </returns>
        public string GetGender()
        {
            return this.gender;
        }

        /// <summary>
        /// Assigns the specified gender to the person.
        /// </summary>
        /// <param name="gender">
        /// The gender to be assigned to the person.
        /// </param>
        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        /// <summary>
        /// Retrieves the person's nationality.
        /// </summary>
        /// <returns>
        /// A string representing the person's nationality.
        /// </returns>
        public string GetNationality()
        {
            return this.nationality;
        }

        /// <summary>
        /// Assigns the specified nationality to the person.
        /// </summary>
        /// <param name="nationality">
        /// The nationality to be assigned to the person.
        /// </param>
        public void SetNationality(string nationality)
        {
            this.nationality = nationality;
        }

        /// <summary>
        /// Returns a formatted string containing the person's details.
        /// Overrides the default ToString() implementation inherited
        /// from the System.Object class.
        /// </summary>
        /// <returns>
        /// A formatted string containing the person's names,
        /// date of birth, gender and nationality.
        /// </returns>
        public override string ToString()
        {
            // Construct and return a formatted representation
            // of the person's personal details.
            return $"Person's Details" +
                   $"\n----------------------------------------" +
                   $"\nName: {this.GetNames()}" +
                   $"\nDate of Birth: {this.GetBirthDate()}" +
                   $"\nGender: {this.GetGender()}" +
                   $"\nNationality: {this.GetNationality()}" +
                   $"\n----------------------------------------\n";
        }
    }
}
