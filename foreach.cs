using System;
class ForEach
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}