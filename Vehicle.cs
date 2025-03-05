using System;

class Vehicle 
{
    public void two_wheeler() 
    {
        Console.WriteLine("This is a tyre");
    }
}

class Bike : Vehicle
{
    public void TVS() 
    {
        Console.WriteLine("This is TVS");
    }

    public static void Main() 
    {
        Bike b = new Bike();
        b.TVS();
        b.two_wheeler();
    }
}
