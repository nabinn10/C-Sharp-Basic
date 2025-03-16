using System;
class ParamModifier
{
    public static int ParamMod(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
             sum += arr[i];
        }
        return sum;

    }
    public static void Main()
    {
        
        int total = ParamMod(1,2,3,4,5);
        
            Console.WriteLine("The Total sum is " + total);
       
    }
}