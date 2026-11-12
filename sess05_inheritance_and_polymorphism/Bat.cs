using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The <see cref="Bat"/> class derives from the <see cref="Mammal"/> class and will 
    /// be used to create Bat objects.
    /// </summary>
    public class Bat : Mammal
    {
        // Instance constant fields
        protected const byte Wings = 2;
        protected const byte Legs = 2;
        protected const byte Ears = 2;

        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}.");
            Console.WriteLine($"The bat eats: {diet}.");
        }

        public void DisplayBatBehaviour()
        {
            Console.WriteLine($"\nThe bat flies");
        }

    }
}
