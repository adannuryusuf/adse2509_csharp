using System;

namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Program to demonstrate read-only property. The program displays the system's current time.
    /// </summary>
    public class ReadOnlyProp
    {

        private DateTime _currentTime = DateTime.Now; // Field

        public DateTime CurrentTime { get { return _currentTime; } }

        static void Main(string[] args)
        {
            Console.WriteLine($"The current time is: {new ReadOnlyProp().CurrentTime:T}");
        }
    }
}
