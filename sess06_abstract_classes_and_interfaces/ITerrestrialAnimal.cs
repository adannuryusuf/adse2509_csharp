
namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// Defines the behaviour of a terrestrial animal.
    /// </summary>
    public interface ITerrestrialAnimal
    {
        /// <summary>
        /// Represents the action of eating performed by the terrestrial animal.
        /// </summary>
        /// <returns>A string describing the eating action.</returns>
        public string Eat();
    }
}