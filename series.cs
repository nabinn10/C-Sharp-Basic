using System;
class Series
{
    public static void Main()
    {
        int i,j;
        for(i=1;i<=5;i++)
        {
            for(j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}