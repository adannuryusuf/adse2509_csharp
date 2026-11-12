using System;

namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Represents a <see cref="Person"/> object with details such as Names, BirthDate, Gender (binary) and Nationality.
    /// </summary>
    public class SimplerPerson
    {
        //=========================================================
        // PERSON PROPERTIES
        //=========================================================

        /// <summary>
        /// Gets or sets the person's names
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the person's date of birth
        /// </summary>
        public DateTime BirthDate { get; set; }
        
        /// <summary>
        /// Gets or sets the person's gender using 'M' or 'm' for male and 'F' or 'f' for female
        /// </summary>        
        public char Gender { get; set; }
        
        /// <summary>
        /// Gets or sets the person's nationality
        /// </summary>
        public string Nationality { get; set; }

        //=========================================================
        // CONSTRUCTORS
        //=========================================================

        /// <summary>
        /// Initialises a new instance/object of the <see cref="SimplerPerson"/> class with default values.
        /// </summary>
        public SimplerPerson()
        {
            this.Name = string.Empty; // or this.Name = "";
            this.BirthDate = DateTime.MinValue;
            this.Gender = 'M';
            this.Nationality = ""; // or this.Nationality = string.empty;
        }

        /// <summary>
        /// Initialises a new instance/object of the <see cref="SimplerPerson"/> class with the specified values.
        /// </summary>
        /// <param name="name">The person's name</param>
        /// <param name="birthDate">The person's birthDate</param>
        /// <param name="gender">The person's gender</param>
        /// <param name="nationality">The person's nationality</param>
        public SimplerPerson(string name, DateTime birthDate, char gender, string nationality)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Nationality = nationality;
        }

        //=========================================================
        // OVERIDDEN METHOD(S)
        //=========================================================
        /// <summary>
        /// Returns a formatted string representation of the person's  details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the person's name, birthdate, gender and nationality.
        /// </returns>
        public override string ToString() 
        {
            return $"Person's Details" +
                $"\n" + new string('-',55) +
                $"\nNames: {this.Name}" +
                $"\nDate of birth: {this.BirthDate}" +
                $"\nGender: {(this.Gender is 'M' or 'm'? "Male" : "Female")}" +
                $"\nNationality: {this.Nationality}" +
                $"\n" + new string('-',55); 
        }
    }

    public class DemoSimplerPerson
    {
        static void Main(string[] args)
        {
            // Declare and instantiate a SimplerPerson object
            SimplerPerson myBuddy = new SimplerPerson();

            // Prompt the user for the buddy/friend's details
            Console.WriteLine(@"Please enter your buddy's name:");
            myBuddy.Name = Console.ReadLine();
            Console.WriteLine(@"Please enter your buddy's date of birth:");
            myBuddy.BirthDate = DateTime.Parse(Console.ReadLine());
            // myBuddy.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(@"Please enter your buddy's gender using 'm' for male or 'f' for female:");
            myBuddy.Gender = char.Parse(Console.ReadLine());
            Console.WriteLine(@"Please enter your buddy's nationality:");
            myBuddy.Nationality = Console.ReadLine();

            // Display myBuddy's details
            Console.WriteLine(myBuddy);

        }
    }
}
