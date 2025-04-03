using System;
using System.IO;

class Program{
    static void Main()
    {
        string path = "D:\\5th-Sem\\C#\\text.txt";
        // Create a file and write to it
        File.WriteAllText(path, "Hello, World!\nThis is a test file.\n");
        // read the file
        string[] lines = File.ReadAllLines(path);
        // Display the contents of the file
        Console.WriteLine("Contents of the file:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}