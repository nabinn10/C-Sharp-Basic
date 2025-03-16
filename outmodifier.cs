using System;
// commony 
class OutModifier
{
    public static void OutMod(out int x, out int y)
    {
      
        x = 10;
        y = 20;
    }
    public static void Main()
    {
        int a, b;
        OutMod(out a, out b);
        Console.WriteLine("a= " + a);
        Console.WriteLine("b= " + b);
    }

}