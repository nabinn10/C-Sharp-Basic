// type helo world
using System;

class Animal 
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Upcasting
        myAnimal.Speak(); // Output: Animal speaks

        Dog myDog = new Dog(); // Upcasting
        myDog.Speak(); // Output: Dog barks


       
        Animal myDogAsAnimal = new Dog(); // Upcasting
        myDogAsAnimal.Speak(); // Output: Dog barks (polymorphism)

    }
}