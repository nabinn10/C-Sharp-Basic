public class Factorial{
    public static void Main()
{
    int a=10;
    int i;
    int fact=1;
    for (i=1;i<=a;i++)
    {
        fact =fact*i;
    }
    System.Console.WriteLine("The factorial of "+a+" is "+fact);
}
}