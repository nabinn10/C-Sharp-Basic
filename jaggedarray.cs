// jagged array
// // creating jagged array with user input
using System;
class Hello{
    public static void Main()
    {
        Console.WriteLine("Enter the element of jagged array");
        int[][] arr = new int[3][];
        for(int i=0;i<3;i++)
        {
            arr[i] = new int[3];
            for(int j=0;j<3;j++)
            {
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(arr[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}