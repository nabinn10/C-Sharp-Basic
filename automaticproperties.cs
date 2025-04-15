using System;

class Program
{
    public int a {
        set;
        get;
    }
    public int b { set; get; }

    public int sum
    {
        get { return a + b; }

    }
    class Test
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.a = 10;
            p.b = 20;
            Console.WriteLine("Sum is: " + p.sum);
        }
    }
}