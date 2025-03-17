using System;
class WhileExample
{
    public static void Main()
    {
        int a = 1,sum=0;
        while (a <= 25)
        {
            sum=sum+a;
            a++;
        }
        Console.WriteLine("Sum of first 25 natural numbers is: "+sum);
    }
}