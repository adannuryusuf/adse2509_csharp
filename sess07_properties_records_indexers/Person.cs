
namespace sess07_properties_records_indexers
{
    public record Person(string Name, byte Age, string Email)
    {
        //=========================================================
        // OVERIDDEN METHOD(S)
        //=========================================================
        /// <summary>
        /// Overrides the default <see cref="ToString"/> method to give a custom representation of the person's  details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the person's name, age and email.
        /// </returns>
        public override string ToString()
        {
            return $"Person's Details" +
                $"\n" + new string('-', 55) +
                $"\nNames: {this.Name}" +
                $"\nAge: {this.Age}" +
                $"\nEmail: {this.Email}" +
                $"\n" + new string('-', 55);
        }
    }
}
