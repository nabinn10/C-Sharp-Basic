using System;

public delegate void DelEventHandler();
class Program
{
    public static event DelEventHandler add;
    static void USA()
    {
        Console.WriteLine("USA");
    }
    static void UK()
    {
        Console.WriteLine("UK");
    }
    static void Nepal()
    {
        Console.WriteLine("Nepal");
    }
    static void Main(string[] args)
    {
        add + = new DelEventHandler(USA);
        add += new DelEventHandler(UK);
        add += new DelEventHandler(Nepal);
        add();
    }

}