using System;
class Class1
{
    // Finalizer
    ~Class1()
    {
        Console.WriteLine("Finalizer called");
    }
    public static void Main()
    {
        Class1 obj = new Class1();
        GC.Collect();
        Console.WriteLine("Main method completed");
    }
}