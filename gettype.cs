using System;
class Hello

{
    public int x=10;
    public int y=20;

}
class Test
{
    static void Main()

    {

    Hello h = new Hello();
    Console.WriteLine(h.GetType().Name); // Output: Hello
    Console.WriteLine(typeof(Hello).Name); // Output: Hello
    Console.WriteLine(h.GetType() == typeof(Hello)); // Output: True
    Console.WriteLine(h.x.GetType().Name); // Output: Int32
    Console.WriteLine(h.y.GetType().FullName); // Output: Int32
    }
}