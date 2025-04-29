using System;

namespace EnumExample
{
    // Define an enum
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the enum
            DaysOfWeek today = DaysOfWeek.Wednesday;

            Console.WriteLine("Today is: " + today);

            // Casting enum to int
            int dayNumber = (int)today;
            Console.WriteLine("Day number is: " + dayNumber);

            // Loop through enum values
            Console.WriteLine("Days of the week:");
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(day);
            }
        }
    }
}