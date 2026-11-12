using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Defines an abstract base class representing an animal.
    /// Provides common data members that can be inherited by derived
    /// classes representing specific types of animals.
    /// </summary>
    /// <remarks>
    /// This class cannot be instantiated directly. It is intended to
    /// serve as a base class for other animal classes, allowing them
    /// to share common attributes such as food preferences and activities.
    /// </remarks>
    public abstract class Animal
    {
        /// <summary>
        /// Stores the type of food consumed by the animal.
        /// </summary>
        /// <remarks>
        /// This field is protected, allowing it to be accessed directly
        /// within the Animal class and its derived classes.
        /// </remarks>
        protected string food;

        /// <summary>
        /// Stores the type of activity performed by the animal.
        /// </summary>
        /// <remarks>
        /// This field is protected, allowing it to be accessed directly
        /// within the Animal class and its derived classes.
        /// </remarks>
        protected string activity;
    }
}
