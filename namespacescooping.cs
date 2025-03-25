using System;
namespace outer
{
    class outerclass
    {
        public void show()
        {
            Console.WriteLine("Outer class");
        }
        public class innerclass
        {
            public void show()
            {
                Console.WriteLine("Inner class");
            }
        }
    } 
}