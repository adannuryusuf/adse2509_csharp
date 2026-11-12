using System;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Represents a scalene triangle, a triangle in which all three sides have
    /// different lengths.
    /// Inherits from <see cref="Triangle"/> and implements <see cref="I2DShape"/>
    /// to provide functionality for calculating its area, perimeter and other
    /// two-dimensional shape properties.
    /// </summary>
    public class ScaleneTriangle : Triangle, I2DShape
    {
        // Private instance fields

        /// <summary>
        /// Represents the length of the first side of the scalene triangle.
        /// </summary>
        private byte sideA;

        /// <summary>
        /// Represents the length of the second side of the scalene triangle.
        /// </summary>
        private byte sideB;

        /// <summary>
        /// Represents the length of the third side of the scalene triangle.
        /// </summary>
        private byte sideC;

        /// <summary>
        /// Initialises a new instance of the <see cref="ScaleneTriangle"/> class
        /// with all three side lengths set to zero.
        /// </summary>
        public ScaleneTriangle()
        {
            this.sideA = 0;
            this.sideB = 0;
            this.sideC = 0;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ScaleneTriangle"/> class
        /// with the specified side lengths.
        /// Validates that all side lengths are positive and satisfy the triangle
        /// inequality theorem.
        /// </summary>
        /// <param name="a">The length of the first side of the triangle.</param>
        /// <param name="b">The length of the second side of the triangle.</param>
        /// <param name="c">The length of the third side of the triangle.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when any side length is not positive or when the sum of any
        /// two side lengths is not greater than the third side.
        /// </exception>
        public ScaleneTriangle(byte a, byte b, byte c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side lengths should be positive.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sum of the lengths of any two sides must be greater than the third side.");

            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        /// <summary>
        /// Calculates the area of the scalene triangle using Heron's formula.
        /// </summary>
        /// <returns>A floating-point value representing the area of the triangle.</returns>
        public override float CalculateArea()
        {
            // Calculate the area of the scalene triangle using Heron's formula
            float semiPerimeter = CalcPerimeter() / 2;

            return (float)Math.Sqrt(semiPerimeter * (semiPerimeter - this.sideA) *
                                    (semiPerimeter - this.sideB) * (semiPerimeter - this.sideC));
        }

        /// <summary>
        /// Calculates the perimeter of the scalene triangle by summing
        /// the lengths of its three sides.
        /// </summary>
        /// <returns>A floating-point value representing the perimeter of the triangle.</returns>
        public virtual float CalcPerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
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
        /// Returns a formatted string containing the three side lengths,
        /// calculated area and perimeter of the scalene triangle.
        /// </summary>
        /// <returns>A formatted string displaying the dimensions and calculated properties
        /// of the scalene triangle.</returns>
        public override string ToString()
        {
            return $"Scalene Triangle's Dimensions" +
                   $"\n" + new string('-', 50) +
                   $"\nSide1: {this.sideA}" +
                   $"\nSide2: {this.sideB}" +
                   $"\nSide3: {this.sideC}" +
                   $"\nArea: {this.CalculateArea()}" +
                   $"\nPerimeter: {this.CalcPerimeter()}" +
                   $"\n" + new string('-', 50);
        }
    }
}
