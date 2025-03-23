using System;
class Hello
{
    public static void Main()
    {
        int a = 1;
        Console.WriteLine("Break statement");
        while (a <= 5)
        {
            if (a == 3)
            {
                break;
            }
            Console.WriteLine(a);
            a++;
        }
        Console.WriteLine("Continue statement");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("Return statement");
        Console.WriteLine(Sum(10, 20));
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}