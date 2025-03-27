using System;

class Hello
{
    public static void Main()
    {
        string[] name = new string[5];
        Console.WriteLine("Enter the names: ");
        for (int i = 0; i < 5; i++)
        {
            name[i] = Console.ReadLine();
        }
        Array.Sort(name); 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(name[i]);
        }
    
    
    }
}