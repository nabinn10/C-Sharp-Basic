using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }