using System;

interface Rose
{
     void rosecolor(string color);
}
interface Lily
{
     void lilycolor(string color);
}
class Flower : Rose, Lily
{
    public void rosecolor(string color) 
    {
        Console.WriteLine("Flower color: "+ color);
    }
    public void lilycolor(string color) 
    {
        Console.WriteLine("Lily color: " + color);
    }
    public static void Main(string[] args)
    {
        Flower f = new Flower();
        f.rosecolor("Red");
        f.lilycolor("White");
    }
}



