using System;

class Complex
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public override string ToString()
    {
        return Real + " + " + Imaginary + "i";
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(3, 4);
        Complex c2 = new Complex(1, 2);

        Complex result = c1 + c2;

        Console.WriteLine("Result: " + result);
    }
}