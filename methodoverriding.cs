using System;

class Program
{
    public virtual void Message()
    {
        Console.WriteLine("This is the base class method.");
    }
}
class Child : Program
{
    public override void Message()
    {
        Console.WriteLine("This is the derived class method.");
    }
    public static void Main()
    {
        Child child = new Child();
        child.Message();
    }

}