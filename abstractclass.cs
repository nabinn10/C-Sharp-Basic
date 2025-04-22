using System;

//  abstract class example
abstract class a
{
   
    public void show() // Concrete method (with implementation)
    {
        Console.WriteLine("This is a concrete method in the abstract class.");
    }
}
class b : a
{
    public void display() // Concrete method (with implementation)
    {
        Console.WriteLine("This is a concrete method in the derived class.");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        b obj = new b(); 
        obj.show(); 
        obj.display();
    }
}