using System;
namespace BridgeLab_Review
{
    class Program 
    {
       public static void Main(string[] args)
        {
            //Problem 1
            Vehicle v1 = new Fleet("Truck", 12000);
            int cost = v1.CalculateDistance(v1.VehicleType);
            v1.DisplayDetails();
            Console.WriteLine($"Maintainance Cost : {cost}");




            // Problem 2
            FindingMinimum fm = new FindingMinimum();
            fm.Class1();
        } 
    }
}