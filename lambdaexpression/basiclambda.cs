using System;


    class Test
    {
    static int Test1() => 5;
    static int Test2(int x) => (x + 10);
        static void Main()
        {
            int x = Test1();
            int result = Test2(x);
            Console.WriteLine(result); // Output: 15
        }
    }