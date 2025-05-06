using System;

class NestedTryExample
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block starts.");
            
            try
            {
                Console.WriteLine("Inner try block starts.");
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inner catch: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Inner finally block executed.");
            }

            int result = 10 / 0; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Outer catch: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Outer finally block executed.");
        }
    }
}