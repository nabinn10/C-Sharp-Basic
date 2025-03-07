// implementation of arithmetic operator in C# with user input
using System;
public class Arithmetic{
    public static void Main()
    {
        int a, b;
        int sum=0, sub=0, mul=0, div=0, mod=0;
        Console.WriteLine("Enter the first number: ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        b=Convert.ToInt32(Console.ReadLine());
        sum=a+b;
        sub=a-b;
        mul=a*b;
        div=a/b;
        mod=a%b;
        Console.WriteLine("The sum is "+sum);
        Console.WriteLine("The subtraction is "+sub);
        Console.WriteLine("The multiplication is "+mul);
        Console.WriteLine("The division is "+div);
        Console.WriteLine("The modulus is "+mod);


    }
}

