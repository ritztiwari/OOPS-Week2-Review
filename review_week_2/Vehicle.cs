
using System;

abstract class Vehicle
{
    private string vehicleType;
    private int distance;

    public Vehicle(string vehicleType, int distance)
    {
        this.vehicleType = vehicleType;
        this.distance = distance;
    }

    public string VehicleType
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }

    public int Distance
    {
        get { return distance; }
        set { distance = value; }
    }

    public abstract int CalculateMaintainance(int distance);

    ~Vehicle()
    {
        Console.WriteLine($"Vehicle object of type {vehicleType} is being garbage collected.");
    }
}


class Truck : Vehicle
{
    public Truck(string vehicleType, int distance) : base(vehicleType, distance) { }

    public override int CalculateMaintainance(int distance)
    {
        return Distance * 2;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Vehicle Type is: {VehicleType}");
        Console.WriteLine($"maintaince cost: {Distance}");
    }

}

class FleetMonitor : IDisposable
{
    private bool isDisposed = false;

    public void Allocate()
    {
        Console.WriteLine("Vehicle allocation started");
    }

    public void Dissolve()
    {
        Console.WriteLine("Vehicle allocation terminated");
    }

    // IDisposable implementation
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Fleet monitoring managed resources released");
            }

            isDisposed = true;
        }
    }

    ~FleetMonitor()
    {
        Dispose(false);
    }
}
