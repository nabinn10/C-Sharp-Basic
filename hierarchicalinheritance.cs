using System;

namespace HierarchicalInheritanceExample
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Derived class 1
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}