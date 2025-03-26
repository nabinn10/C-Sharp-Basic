using System;

class Hello
{
    public static void Main()
    {
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] c = new int[2, 2];
        Console.WriteLine("Enter the elements of first matrix");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter the elements of second matrix");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The sum of the two matrices is");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
                Console.Write(c[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}