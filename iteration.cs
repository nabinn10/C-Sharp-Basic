using System;
class Iteration
{
    public static void Main()
    {
        int a = 1;
        Console.WriteLine("While loop");
        while (a <= 5)
        {
            Console.WriteLine(a);
            a++;
        }
        Console.WriteLine("For loop");
        int i=1;
        for (i = 1;i<=5;i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Do-While loop");
        int j = 1;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j <= 5);



    }
}