using System;
using System.Collections.Generic;

class Program
{
    static void Main()
{
    List<int> numbers = new List<int>();
    numbers.Add(5);
    numbers.Add(3);
    numbers.Add(8);

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
}