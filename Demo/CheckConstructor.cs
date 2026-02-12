using System;

public class parent
{
    public parent()
    {
        Console.WriteLine("Parent Constructor called");
    }
    public parent(int x)
    {
        Console.WriteLine("Parent Parameterized Constructor called with value: " + x);
    }
}
public  class CheckConstructor : parent
    {
       public CheckConstructor() : base(10)
        {
            Console.WriteLine("Constructor called");
        }
   
    public static void Main()
    {
        Console.WriteLine("In Main Method");
        // CheckConstructor obj = new CheckConstructor();
    }

    }