using System;
class Hello
{
    public static void Main()
    {
        int a, b;
        
        // Getting user input
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        // Calling sum function
        Console.WriteLine("The sum of " + a + " and " + b + " is " + sum(a, b));
    }

    public static int sum(int a, int b) // Fixed method return type
    {
        return a + b;
    }
}
