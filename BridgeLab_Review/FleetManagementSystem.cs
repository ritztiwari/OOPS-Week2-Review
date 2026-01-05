/*Design a Vehicle Fleet Management System that calculates maintenance cost based on 
vehicle usage and type. 
The system must manage fleet monitoring resources efficiently. 

� OOP Concepts Used 
 Encapsulation: Vehicle usage data hidden 
 Inheritance: Vehicle → Truck 
 Abstraction: Abstract Vehicle 
 Polymorphism: Maintenance calculation 
 Object Modeling: Fleet–Vehicle relationship 
 Garbage Collection & Dispose: FleetMonitor cleanup 

� Object Modeling 
 Fleet has Vehicles 
 Vehicles incur maintenance costs 

� Class Diagram


�
� Input 
Vehicle Type: Truck 
Distance Travelled: 12000 km 

� Output 
Vehicle Type: Truck 
Maintenance Cost: 24000 
Fleet monitoring resources released
*/

using System;

public abstract class Vehicle
{
    private string vehicleType;
    private int distanceTravelled;

    public Vehicle(string vehicle, int distance)
    {
        this.vehicleType = vehicle;
        this.distanceTravelled = distance;
    }

    public string VehicleType
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }
    
    public int Distance
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public abstract int CalculateDistance(string type);

    public void DisplayDetails()
    {
        Console.WriteLine($"Vehicle Type : {VehicleType}");
        Console.WriteLine($"Distance Travelled : {Distance}");
    }
}

public class Fleet : Vehicle
{

    public Fleet(string type,int distance) : base(type, distance)
    {
    }

    public override int CalculateDistance(string type)
    {
        if(type == "Truck")
        {
            return Distance * 5;
        }
        else if (type == "Car")
        {
            return Distance * 4;
        }
        else
        {
            return Distance * 2;
        }
    }
}