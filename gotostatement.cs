using System;

class Hello
{
    public static void Main()
    {
        int i=1;
        Start:

        if (i<+5)
        {
            Console.WriteLine(i);
            i++;
            goto Start;
        }
    }

    

}