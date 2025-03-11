// creating 2d array with user input
// give answer
// 1 2 3
// 4 5 6
// 7 8 9
using System;   
class Hello
{
    public static void Main()
    {
        int[,] arr = new int[3,3];
        Console.WriteLine("Enter the elements of 2D array");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                arr[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}