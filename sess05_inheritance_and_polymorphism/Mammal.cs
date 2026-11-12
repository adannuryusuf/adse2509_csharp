using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Defines an abstract base class representing a mammal.
    /// Inherits common attributes from the Animal class and introduces
    /// additional characteristics and behaviours specific to mammals.
    /// </summary>
    /// <remarks>
    /// This class cannot be instantiated directly. It is intended to serve
    /// as a base class for more specialised mammal classes.
    /// It inherits the protected fields food and activity from the Animal
    /// class and introduces the habitat field.
    /// </remarks>
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Stores the natural habitat or environment in which the mammal lives.
        /// </summary>
        /// <remarks>
        /// This field is protected, allowing it to be accessed within the
        /// Mammal class and its derived classes.
        /// </remarks>
        protected string habitat;

        // Instance methods

        /// <summary>
        /// Defines the eating behaviour of a mammal based on its diet.
        /// </summary>
        /// <param name="diet">
        /// A string describing the type of food consumed by the mammal.
        /// </param>
        /// <remarks>
        /// This is an abstract method and does not provide an implementation
        /// in the Mammal class. Derived classes must override this method
        /// to specify the eating behaviour appropriate to the particular mammal.
        /// </remarks>
        public abstract void Eat(string diet);

        /// <summary>
        /// Displays a message indicating that the specified mammal
        /// gives birth to young ones.
        /// </summary>
        /// <param name="name">
        /// The name or type of mammal whose reproductive behaviour is being described.
        /// </param>
        /// <remarks>
        /// This is an instance method that can be inherited and called
        /// by classes derived from Mammal.
        /// </remarks>
        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name}, gives birth to young ones.");
        }
    }
}
