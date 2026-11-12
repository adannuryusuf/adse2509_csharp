using sess05_inheritance_and_polymorphism;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Represents an abstract triangular shape.
    /// Inherits from <see cref="Shape"/> and provides a specialised contract
    /// for calculating the area of triangular shapes.
    /// </summary>
    public abstract class Triangle : Shape
    {
        /// <summary>
        /// Calculates the area of the triangular shape.
        /// </summary>
        /// <returns>A floating-point value representing the area of the triangle.</returns>
        public abstract override float CalculateArea();
    }
}
