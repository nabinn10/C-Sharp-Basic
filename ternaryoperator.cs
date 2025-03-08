// example of terenary operatpor
using System;
public class TernaryOperator{
    public static void Main()
    {
        int a, b;
        int max=0;
        Console.WriteLine("Enter the first number: ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        b=Convert.ToInt32(Console.ReadLine());
        max=(a>b)?a:b;
        Console.WriteLine("The maximum number is "+max);
    }
}