using System;

namespace SimpleInheritance
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat(); // Method from the base class
            myDog.Bark(); // Method from the derived class
        }
    }
}