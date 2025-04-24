using System;

sealed class SealedClass
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
    
    public void AdditionalMethod()
    {
        Console.WriteLine("This is an additional method.");
    }

    public void AnotherMethod()
    {
        Console.WriteLine("This is another method.");
    }

}

class B : SealedClass
{
    // This will cause a compile-time error because SealedClass is sealed and cannot be inherited.
    // public void NewMethod()
    // {
    //     Console.WriteLine("This is a new method in class B.");
    // }
}