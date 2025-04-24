using System;


class Hello{
    public void display()
    {
        int color = 1;
        Console.WriteLine(color);
    }
    public virtual void result()
    {
        int color = 3;
        Console.WriteLine(color);
    }
}
class Base:Hello
{
    public void display()
    {
        int color = 2;

       result(); 
       base.result(); // Calls the result method from the Hello class

        Console.WriteLine(color);
    }
    public override void result()
    {
        int color = 4;
        Console.WriteLine(color);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base obj = new Base();
        obj.display(); // Output: 2

       
    }
}