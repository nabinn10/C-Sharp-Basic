using System;

class Person{
    
}
class Employee : Person
{

    public void emp_details(string postion)
    {
        Console.WriteLine("This is the employee's details from employee."+postion);
    }
    
   
}
class Manager : Employee
{
    public void Department()
    {
        Console.WriteLine("This is the department of the person.");
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Manager m = new Manager();
        m.Department();
        m.emp_details("Manager");
    }
}