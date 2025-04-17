using System;

namespace MultilevelInheritanceExample
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
    class Mammal : Animal
    {
        public void Walk()
        {
            Console.WriteLine("This mammal walks on land.");
        }
    }

    // Further derived class
    class Dog : Mammal
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

            // Access methods from all levels of inheritance
            myDog.Eat();  // From Animal class
            myDog.Walk(); // From Mammal class
            myDog.Bark(); // From Dog class
        }
    }
}