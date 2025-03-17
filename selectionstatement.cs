using System;
class Hello
{
    public static void Main()
    {
        int a = 10;
        int b = 20;
        if (a > b)
        {
            Console.WriteLine(a+ " is greater than" +b);
        }
        else if (a == b)
        {
            Console.WriteLine(a+ " is equal to" +b);
        }
        else
        {
            Console.WriteLine(b+" is greater than "+a);
        }
    }
}