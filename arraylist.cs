using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Add elements to the ArrayList
        arrayList.Add(10);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        arrayList.Add(true);

        // Display elements in the ArrayList
        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        arrayList.Remove(10);

        // Insert an element at a specific index
        arrayList.Insert(1, "World");

        // Display updated ArrayList
        Console.WriteLine("\nUpdated ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}