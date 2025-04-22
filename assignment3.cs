using System;

abstract class Shape
{
    public abstract void Draw(); // Abstract method (no implementation)
    
    public void Display() // Concrete method (with implementation)
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Draw() // Providing implementation for the abstract method
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Shape shape = new Circle(); // Polymorphism
        shape.Display();
        shape.Draw();
    }
}

