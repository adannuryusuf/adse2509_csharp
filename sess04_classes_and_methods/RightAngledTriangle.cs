using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Create Right angled triangles with base, height and hypotenuse.
    /// </summary>
    public class RightAngledTriangle
    {
        // Private instance variables
        private byte height;
        private byte @base;
        private byte hypotenuse;

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class
        /// with all dimensions set to 0 'zero'.
        /// </summary>
        public RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0;
            this.hypotenuse = 0;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="RightAngledTriangle"/> class
        /// using the specified base and height.
        /// Calculates the hypotenuse using the Pythagorean theorem.
        /// </summary>
        /// <param name="height">The height of the right-angled triangle.</param>
        /// <param name="base">The base of the right-angled triangle.</param>
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(height * height + @base * @base));
            //this.hypotenuse = (byte)(Math.Sqrt(Math.Pow(height,2) + Math.Pow(@base,2)));
        }

        /// <summary>
        /// Calculates the area of the right-angled triangle.
        /// </summary>
        /// <returns>The area of the triangle as an integer.</returns>
        private int CalculateArea() { return (int)(.5 * this.@base * this.height); } // not same as 1/2 * this.@base * this.height


        /// <summary>
        /// Calculates the perimeter of the right-angled triangle.
        /// </summary>
        /// <returns>The perimeter of the triangle as an integer.</returns>
        private int CalculatePerimeter() { return  this.@base + this.height + this.hypotenuse; }


        /// <summary>
        /// Returns a formatted string containing the dimensions,
        /// area and perimeter of the right-angled triangle.
        /// </summary>
        /// <returns>
        /// A formatted string displaying the base, height, hypotenuse,
        /// area and perimeter of the triangle.
        /// </returns>
        public override string ToString()
        {
            return $"Right-Angled Triangle's Dimensions" +
                $"\n{new string('-',50)}" +
                $"\nBase: {this.@base}" +
                $"\nHeight: {this.height}" +
                $"\nHypotenuse: {this.hypotenuse}" +
                $"\nArea: {this.CalculateArea()}" +
                $"\nPerimeter: {this.CalculatePerimeter()}" +
                $"\n{new string('-', 50)}";
        }

    }
}
