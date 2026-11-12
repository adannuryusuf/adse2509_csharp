using System;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// The <see cref="I2DShape"/> interface has methods that all 2-dimensional shapes must
    /// implement to calculate their perimeter or circumference.
    /// </summary>
    public interface I2DShape
    {
        /// <summary>
        /// Method to calculate the perimeter of the 2-dimensional shape.
        /// </summary>
        /// <returns>The perimeter of the shape as a float.</returns>
        public float CalcPerimeter();

        /// <summary>
        /// Default method to calculate the circumference of the 2-dimensional circle
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        /// <returns>The circumference of the circle as a float</returns> 
        public virtual float CalcCircumference(int radius) 
        { return (float)(Math.PI * (radius * 2)); }
    }
}
