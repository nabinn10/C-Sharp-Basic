using System;

static class MyStaticClass
{
    public static int id;
    public static string name;

    public static void DisplayInfo()
    {
        Console.WriteLine("ID: " + id + ", Name: " + name);
    }

}
class Program
{
    static void Main(string[] args)
    {
        MyStaticClass.id = 1;
        MyStaticClass.name = "Static Class Example";
        MyStaticClass.DisplayInfo();
    }
}