using System;

interface IFirst
{
    void MethodA();
}

interface ISecond
{
    void MethodB();
}

class MultipleInheritance : IFirst, ISecond
{
    public void MethodA()
    {
        Console.WriteLine("MethodA from IFirst");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB from ISecond");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MultipleInheritance obj = new MultipleInheritance();
        obj.MethodA();
        obj.MethodB();
    }
}