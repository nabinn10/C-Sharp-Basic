using System;
using System.Collections;

class Hello
{
    static void Main()
    {
        Hashtable student = new Hashtable();
        student.Add(101, "Nabin");
        student.Add(102, "Sabin");
        student.Add(103, "Rabin");

        foreach (DictionaryEntry entry in student)
        {
            Console.WriteLine("Key: " + entry.Key + " Value: " + entry.Value);
        }
    }
}