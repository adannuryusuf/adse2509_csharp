using System;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Represents a right-angled triangle with a base, height and hypotenuse.
    /// Inherits from <see cref="Triangle"/> and implements <see cref="I2DShape"/>
    /// to provide functionality for calculating its area, perimeter and other
    /// two-dimensional shape properties.
    /// </summary>
    public class RightAngledTriangle : Triangle, I2DShape
    {
        // Private instance fields

        /// <summary>
        /// Gets or sets the height of the right-angled triangle.
        /// </summary>
        private byte height;

        /// <summary>
        /// Gets or sets the base length of the right-angled triangle.
        /// </summary>
        private byte @base;

        /// <summary>
        /// Gets or sets the length of the hypotenuse of the right-angled triangle.
        /// </summary>
        private byte hypotenuse;

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class
        /// with all dimensions set to zero.
        /// </summary>
        public RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0;
            this.hypotenuse = 0;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class
        /// with the specified height and base length.
        /// Calculates the hypotenuse using the Pythagorean theorem.
        /// </summary>
        /// <param name="height">The height of the right-angled triangle.</param>
        /// <param name="base">The base length of the right-angled triangle.</param>
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(height * height + @base * @base));
        }

        /// <summary>
        /// Calculates the perimeter of the right-angled triangle by summing
        /// its base, height and hypotenuse.
        /// </summary>
        /// <returns>A floating-point value representing the perimeter of the triangle.</returns>
        public float CalcPerimeter()
        {
            return this.height * this.@base * this.hypotenuse;
        }

        /// <summary>
        /// Calculates the circumference of a circle using the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>A floating-point value representing the circumference of the circle.</returns>
        public float CalcCircumference(int radius)
        {
            return 0.0f;
        }

        /// <summary>
        /// Calculates the area of the right-angled triangle using its base and height.
        /// </summary>
        /// <returns>A floating-point value representing the area of the triangle.</returns>
        public override float CalculateArea()
        {
            return .5f * this.@base * this.height;
        }

        /// <summary>
        /// Returns a formatted string containing the dimensions, area and perimeter
        /// of the right-angled triangle.
        /// </summary>
        /// <returns>A formatted string displaying the triangle's dimensions and calculated properties.</returns>
        public override string ToString()
        {
            return $"Right-Angled Triangle's Dimensions" +
                   $"\n" + new string('-', 50) +
                   $"\nBase: {this.@base}" +
                   $"\nHeight: {this.height}" +
                   $"\nHypotenuse: {this.hypotenuse}" +
                   $"\nArea: {this.CalculateArea()}" +
                   $"\nPerimeter: {this.CalcPerimeter()}" +
                   $"\n" + new string('-', 50);
        }
    }
}
