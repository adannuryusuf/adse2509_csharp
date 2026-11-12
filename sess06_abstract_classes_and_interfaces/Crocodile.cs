using System;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Represents a crocodile, an animal that can live in both marine and terrestrial environments.
    /// Implements <see cref="IMarineAnimal"/> and <see cref="ITerrestrialAnimal"/> to provide
    /// different eating behaviours depending on the environment.
    /// </summary>
    public class Crocodile : IMarineAnimal, ITerrestrialAnimal
    {
        /// <summary>
        /// Represents the eating behaviour of a terrestrial crocodile.
        /// </summary>
        /// <returns>A string describing the terrestrial animals eaten by the crocodile.</returns>
        string ITerrestrialAnimal.Eat()
        {
            return "Crocodile eats land animals like gnu and zebras.";
        }

        /// <summary>
        /// Represents the eating behaviour of a marine crocodile.
        /// </summary>
        /// <returns>A string describing the fish and other marine animals eaten by the crocodile.</returns>
        string IMarineAnimal.Eat()
        {
            return "Crocodile eats fish and other marine animals.";
        }

        /// <summary>
        /// Retrieves the eating behaviour of the crocodile through the
        /// <see cref="ITerrestrialAnimal"/> interface.
        /// </summary>
        /// <returns>A string describing the terrestrial animals eaten by the crocodile.</returns>
        public string EatTerrestrial()
        {
            ITerrestrialAnimal terrestrialAnimal = this;
            return terrestrialAnimal.Eat();
        }

        /// <summary>
        /// Retrieves the eating behaviour of the crocodile through the
        /// <see cref="IMarineAnimal"/> interface.
        /// </summary>
        /// <returns>A string describing the marine animals eaten by the crocodile.</returns>
        public string EatMarine()
        {
            IMarineAnimal marineAnimal = this;
            return marineAnimal.Eat();
        }

        /// <summary>
        /// Serves as the entry point of the application.
        /// Creates a crocodile instance and displays its eating behaviour
        /// through both marine and terrestrial interfaces.
        /// </summary>
        /// <param name="args">Command-line arguments supplied to the application.</param>
        static void Main(string[] args)
        {
            // Declare and instantiate a Crocodile object
            Crocodile crocodile = new Crocodile();

            // Display the crocodile's diet from the IMarine interface
            Console.WriteLine($"From IMarine: {crocodile.EatMarine()}");

            // Display the crocodile's diet from the ITerrestrial interface
            Console.WriteLine($"From ITerrestrial: {crocodile.EatTerrestrial()}");
        }
    }
}
