using System.Collections.Generic;
using System;

class Test<T>
{
    T[] items = new T[5];
    int count = 0;
    public void Add(T item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Array is full");
        }
    }
    public void Display()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Test<int> obj = new Test<int>();
        obj.Add(1);
        obj.Add(2);
        obj.Add(3);
        obj.Add(4);
        obj.Add(5);
        obj.Display();
    }
}