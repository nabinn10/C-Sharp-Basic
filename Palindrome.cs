public class Palidnrome
{
    public static void Main()
    {
        int n, r, sum = 0, temp;
        n = 454;
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
        {
            System.Console.WriteLine("Number is Palindrome.");
        }
        else
        {
            System.Console.WriteLine("Number is not Palindrome.");
        }
    }
}