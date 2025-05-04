using System.Collections.Generic;
using System;   
class Program{

    static void swap<t>(ref t a, ref t b){
        t temp = a;
        a = b;
        b = temp;
    }
    static void Main(){r
        int a = 10, b = 20;
        Console.WriteLine("Before swap: a "+a+" b = "+b);
        swap<int>(ref a, ref b);
        Console.WriteLine("Swapped values: a = " + a + ", b = " + b);

    }
}