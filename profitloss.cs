using System;

class Hello{
    public static void Main()
{
    Console.WriteLine("Enter the Selling Price");
    int sp = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Cost Price");
    int cp = Convert.ToInt32(Console.ReadLine());

    if (cp>sp)
    {
        Console.WriteLine("This is Loss and the loss amount is "+(cp-sp));
    }
    else
    {
         Console.WriteLine("This is Profit and the Profit amout is "+(sp-cp));
    }


}
}