using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The <see cref="Dolphin"/> class derives from the <see cref="Mammal"/> class and will be used to create Dolphin objects/instances
    /// </summary>
    public class Dolphin : Mammal
    {
        // Instance constant fields
        protected const byte Flippers = 2;
        protected const byte Snout = 1;
        protected const byte Blowhole = 1;
        protected const byte Fins = 5;

        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"The dolphin eats:  {diet}");
        }

        public void DisplayDolphinBehaviour()
        {
            Console.WriteLine($"\nThe dolphin swims");
        }
    }
}
