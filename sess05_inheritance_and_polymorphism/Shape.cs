using System;

namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Defines an abstract base class representing a geometric shape.
    /// Provides a common method for calculating the area of two-dimensional
    /// shapes or the surface area of three-dimensional shapes.
    /// </summary>
    /// <remarks>
    /// This class cannot be instantiated directly. It is intended to be
    /// inherited by derived classes representing specific geometric shapes,
    /// which must provide their own implementation of the CalculateArea method.
    /// </remarks>
    public abstract  class Shape
    {
        /// <summary>
        /// Defines an abstract base class representing a geometric shape.
        /// Provides a common method for calculating the area of two-dimensional
        /// shapes or the surface area of three-dimensional shapes.
        /// </summary>
        /// <remarks>
        /// This class cannot be instantiated directly. It is intended to be
        /// inherited by derived classes representing specific geometric shapes,
        /// which must provide their own implementation of the CalculateArea method.
        /// </remarks>
        public abstract float CalculateArea(); 
    }
}
