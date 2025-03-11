using System;
class HEllo{
    public static void Main()
    {
        int a=10;
        System.Console.WriteLine("The factorial of "+a+" is "+fact(a));
    }
    public static int fact(int a)
    {
        if( a==1 || a==0)
        {
            return 1;
        }
        else
        {
            return a*fact(a-1);
        }
    }
}