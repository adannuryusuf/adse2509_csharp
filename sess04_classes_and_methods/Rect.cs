using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Represents a rectangle defined by its length and width.
    /// Provides methods to set and retrieve its dimensions,
    /// calculate its area and perimeter, and display its details.
    /// </summary>
    public class Rect
    {
        // Fields
        private uint length;
        private uint width;

        // Constructors
        public Rect()
        {
            this.length = 0;
            this.width = 0;
        }
        public Rect(uint length, uint width)
        {
            this.length = length;
            this.width = width;
        }

        public void SetLength(uint length) { this.length = length; }

        public uint GetLength() {  return this.length; }
        public void SetWidth(uint width) { this.width = width; }

        public uint GetWidth() {  return this.width; }

        public ulong CalcArea() { return this.length *  this.width; }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter, calculated as twice the sum of the length and width.</returns>
        public ulong CalcPerimeter() {  return 2 * (this.length + this.width); }

        /// <summary>
        /// Returns a formatted string containing the rectangle's dimensions,
        /// area and perimeter.
        /// </summary>
        /// <returns>A formatted string displaying the rectangle's details.</returns>
        public override string ToString()
        {
            return $"Rectangle's Dimensions" +
                "\n" + new string('-',50) +
                $"\nLength: {this.GetLength()}" +
                $"\nWidth: {this.GetWidth()}" +
                $"\nArea: {this.CalcArea()}" +
                $"\nPerimeter: {this.CalcPerimeter()}" +
                "\n" + new string('-',50);
        }

    }
}
