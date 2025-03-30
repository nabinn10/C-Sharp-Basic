using System;

using System.Text;
class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 5; i++)
        {
            sb.Append(i).Append(" ");
        }
        Console.WriteLine(sb);
    }
}