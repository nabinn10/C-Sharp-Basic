using System;
class Vehicle
{

}
class Car : Vehicle
{
    public void name(string name)
    {
        Console.WriteLine("This is the name of the car: " + name);
    }
}
class Truck : Vehicle
{   
    public void name(string name)
    {
        Console.WriteLine("This is the name of the truck: " + name);
    }
   
}
class Motorcycle : Vehicle
{
    public void name(string name)
    {
        Console.WriteLine("This is the name of the motorcycle: " + name);
    }
    
}
class Progeam
{
    public static void Main(string[] args)
    {
        Car c = new Car();
        c.name("BMW");
        Truck t = new Truck();
        t.name("TATA");
        Motorcycle m = new Motorcycle();
        m.name("KTM");
    }

}