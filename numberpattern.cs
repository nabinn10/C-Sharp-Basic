using System;

class Hello
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)  // Outer loop for rows
        {
            for (int j = 1; j <= i; j++)  // Inner loop for repeating numbers
            {
                Console.Write(i);
            }
            Console.WriteLine();  // Move to the next line
        }
    }
}
