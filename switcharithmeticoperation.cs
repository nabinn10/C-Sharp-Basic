using System;
class Hello
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operation");
        string operation = Console.ReadLine();
        switch (operation)
        {
            case "+":
                Console.WriteLine("Addition of two numbers is " + (num1 + num2));
                break;
            case "-":
                Console.WriteLine("Subtraction of two numbers is " + (num1 - num2));
                break;
            case "*":
                Console.WriteLine("Multiplication of two numbers is " + (num1 * num2));
                break;
            case "/":
                Console.WriteLine("Division of two numbers is " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}