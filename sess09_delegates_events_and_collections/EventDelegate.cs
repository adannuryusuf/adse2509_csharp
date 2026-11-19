using System;
namespace sess09_delegates_events_and_collections;
/// <summary>
/// defines thed signature of an event handler that receives a string value
/// </summary>
/// <param name="value">the string value supplied to the event handler</param>
public delegate void MyEventHandler(string value);
/// <summary>
/// Demonstrates the use of delegatees and events to notify subscribers whenever a user enters a new string through the console
/// </summary>
/// <remarks>
/// the application continues prompting the user until they enter "exit" regardless of the letter casing used
/// </remarks>
public class EventDelegate
{
    static void Main(string[] args)
    {
       // create an instance of the event publisher
        EventPublisher eventPub = new EventPublisher();
        // subscribe to the ValueChanged event
        eventPub.ValueChanged += UserStringChanged;

        try
        {
            string? userString;
            do
            {
                // Request/prompt the user to enter a string value
                Console.Write("Please enter a string value (or type 'exit' to quit): ");
                userString = Console.ReadLine();

                // Handle null input(e.g, when the input stream is closed)
                if (userString == null)
                {
                    Console.WriteLine("No input received. Goodbye!");
                    break;
                }

                // Exist the application if the user enters 'exit'
                if (!string.Equals(userString, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    // Assign the user input to the Value property of the event publisher
                    eventPub.Value = userString;
                }
            }
            while(!string.Equals(userString, "exit", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Goodbye!");
    }
    finally
    {
        // Unsubscribe from the event when its no longer required
        eventPub.ValueChanged -= UserStringChanged;
    }
    }
    private static void UserStringChanged(string newInput)
    {
        // Display the updated string value received from the event publisher
        Console.WriteLine($"The user has typed: \"{newInput}\"\n");
    }
}
internal class EventPublisher
{
   /// <summary>
   /// Stores the current string value maintained by the publisher
   /// </summary>
    private string? _val;

    /// <summary>
    /// occurs when the <see cref="Value"/> property is assigned a new value
    /// </summary>
    /// <remarks>
    /// Subscribers receive the updated string through the event handler
    /// </remarks>
    public event MyEventHandler? ValueChanged;

    public string? Value
    {
        get => _val;
        set
        {
            // update the stored string value
            _val = value;
            // notify subscribers that the value has changed
            OnValueChanged(_val);
        }
    }
    /// <summary>
    /// Raises the <see cref="ValueChanged"/> event
    /// </summary>
    /// <param name="value">The updated string value to pass to the registered event handlers
    /// </param>
    protected virtual void OnValueChanged(string? value)
    {
        ValueChanged?.Invoke(value!);
    }
}
