//using System;

//internal class Program
//{
//    internal static void Main(string[] args)
//    {
//        FleetMonitor f = new FleetMonitor();
//        f.Allocate();

//        Vehicle vehicle1 = new Truck("truck", 12000);
//        Vehicle vehicle2 = new Truck("car", 15000);

//        int maintainenceCost = vehicle1.CalculateMaintainance(vehicle1.Distance);
//        Console.WriteLine($"vehicle type: {vehicle1.VehicleType}");
//        Console.WriteLine($"vehicle type: {maintainenceCost}\n");

//int maintainenceCost2 = vehicle2.CalculateMaintainance(vehicle2.Distance);
//        Console.WriteLine($"vehicle type: {vehicle2.VehicleType}");
//        Console.WriteLine($"vehicle maintainance cost: {maintainenceCost2}");


//        //GC.Collect();
//        //GC.WaitForPendingFinalizers();

//        //Console.WriteLine("Garbage Collection completed.");
//        //f.Dessolve();

//        using(FleetMonitor d = new FleetMonitor())
//        {
//        }
//    }
//}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter digit string: ");
        string num = Console.ReadLine();

        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());

        List<string> result = Solve(num, target);

        Console.WriteLine("\nValid Expressions:");
        if (result.Count == 0)
            Console.WriteLine("No valid expression found.");
        else
            foreach (string s in result)
                Console.WriteLine(s);
    }

    static List<string> Solve(string num, int target)
    {
        List<string> exp = new List<string>();
        List<long> val = new List<long>();
        List<long> last = new List<long>();

        int n = num.Length;

        // Initialize with first number chunks
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && num[0] == '0') break;

            string part = num.Substring(0, i + 1);
            long v = long.Parse(part);

            exp.Add(part);
            val.Add(v);
            last.Add(v);
        }

        for (int pos = 1; pos < n; pos++)
        {
            List<string> nextExp = new List<string>();
            List<long> nextVal = new List<long>();
            List<long> nextLast = new List<long>();

            for (int i = 0; i < exp.Count; i++)
            {
                for (int j = pos; j < n; j++)
                {
                    if (j > pos && num[pos] == '0') break;

                    string part = num.Substring(pos, j - pos + 1);
                    long v = long.Parse(part);

                    // +
                    nextExp.Add(exp[i] + "+" + part);
                    nextVal.Add(val[i] + v);
                    nextLast.Add(v);

                    // -
                    nextExp.Add(exp[i] + "-" + part);
                    nextVal.Add(val[i] - v);
                    nextLast.Add(-v);

                    // *
                    long mul = val[i] - last[i] + last[i] * v;
                    nextExp.Add(exp[i] + "*" + part);
                    nextVal.Add(mul);
                    nextLast.Add(last[i] * v);
                }
            }

            exp = nextExp;
            val = nextVal;
            last = nextLast;
        }

        List<string> result = new List<string>();
        for (int i = 0; i < exp.Count; i++)
            if (val[i] == target)
                result.Add(exp[i]);

        return result;
    }
}
