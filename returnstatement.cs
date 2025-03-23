using System;

class Hello
{
    public static void Main()
    {
        
        int n= Sum(10, 20);
        Console.WriteLine("The sum is " +n);
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}