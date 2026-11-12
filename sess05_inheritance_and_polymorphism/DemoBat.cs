using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Program to demonstrate inheritance and object instantiation
    /// </summary>
    public class DemoBat : Bat
    {
        static void Main()
        {
            DemoBat batman = new DemoBat();

            // Set the properties for the Bat from the various base classes
            batman.food = "insects or fruits"; // From the Animal base class
            batman.activity = "Bats are nocturnal"; // From the Animal base class
            // batman.activity = "Batman rounds up criminals like Joker & Harly Quinn in Gotham city."
            batman.habitat = "Batcave in Gotham city"; // From the Mammal class

            // Display the details of the DemoBat instance
            batman.DisplayBatDetails();
        }

        private void DisplayBatDetails()
        {
            Console.WriteLine($"Details of the bat" +
                          $"\n" + new string('-', 50));
            this.Eat(food);
            Console.WriteLine(
                $"Number of wings: {Wings}" +
                $"\nNumber of legs: {Legs}" +
                $"\nNumber of ears: {Ears}");
            Console.Write("Reproduction: ");
            MultiplyMammal("\nBat");
            Console.Write("Behaviour: ");
            DisplayBatBehaviour();
            Console.WriteLine($"" + new string('-', 50));
        }
    }
}
