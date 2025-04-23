using System;

class Overloading
{
    public static void Main()
    {
        Console.WriteLine("Overloading Example");

        // Calling the method with different parameters
        Console.WriteLine("Sum of 5 and 10: " + Add(5, 10)); 
        Console.WriteLine("Sum of 5.5 and 10.5: " + Add(5.5, 10.5)); // Calls the second method
        Console.WriteLine("Sum of 5, 10, and 15: " + Add(5, 10, 15)); // Calls the third method
    }

    public static int Add(int a, int b)
    {
        return a + b; 
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}