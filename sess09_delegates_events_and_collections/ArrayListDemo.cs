using System;
using System.Collections;
namespace sess09_delegates_events_and_collections;
/// <summary>
/// program to demonstrate the <see cref="ArrayList"/> class and some of its methods
/// </summary>
public class ArrayListDemo
{
    static void Main(string[] args)
    {
        //declare andinstantiate an ArrayList object
        ArrayList fruitList = new ArrayList();

        // display the initial capacity of the fruitlist object
        Console.WriteLine($"The initial capacity of the fruitlist is: {fruitList.Capacity}");

        //Add fruits to the fruitlist 
        fruitList.Add("Apple");
        fruitList.Add("Mango");
        fruitList.Add("Pineapple");
        fruitList.Add("Watermelon");
        fruitList.Add("Strawberry");
        fruitList.Add("Plums");
        fruitList.Add("Guava");
        fruitList.Add("Avocado");
        fruitList.Add("Apple");
        fruitList.Add("Durian");
        fruitList.Add("Grapes");

        // Display the original list of fruits
        Console.WriteLine($"The original fruitlist has {fruitList.Count} fruits, and they are listed below: ");

        foreach(string fruit in fruitList)
        Console.WriteLine(fruit);

        //insert a fruit before mango
        fruitList.Insert(4, "Lemon");
        //replace orange with kiwi fruit
        fruitList[3] = "Kiwi fruit";

        // display the modified and unsorted list of fruits
        Console.WriteLine($"The modified fruitList has {fruitList.Count} fruits, and they are listed below: ");
        for(uint n = 0; n < fruitList.Count; n++)
            Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

        // Sort the 'fruitList' in reverse lexicographical (descending) order
        fruitList.Sort(); // Sort fruitList in ascending order
        fruitList.Reverse(); // Reverse the above sort (effectively sorting them in descending order)
        Console.WriteLine($"The fruitList in reverse lexicographical order is:");
        for (uint n = 0; n < fruitList.Count; n++)
            Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

        
    }
}
