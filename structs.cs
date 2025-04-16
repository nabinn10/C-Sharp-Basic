using System;


public struct Point
{
    int x,y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Display()
    {
        Console.WriteLine("Point: (" + x + ", " + y + ")");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Point p = new Point(10, 20);
        p.Display();
    }
}