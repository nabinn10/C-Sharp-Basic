using System;
class Hello
{

    public static void Main()
    {
        int i,j;
        for (i = 1; i <= 10; i++)
        {
            for (j = 1; j <= 10; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine();
        }
    }
}