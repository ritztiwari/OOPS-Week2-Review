//using System;
//public class Tuples
//{

//    int[] xs = new int[] { 4, 7, 9 };
//    var limits = FindMinMax(xs);
//    Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
//// Output:
//// Limits of [4 7 9] are 4 and 9

//int[] ys = new int[] { -9, 0, 67, 100 };
//    var(minimum, maximum) = FindMinMax(ys);
//    Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
//// Output:
//// Limits of [-9 0 67 100] are -9 and 100

//(int min, int max) FindMinMax(int[] input)
//    {
//        if (input is null || input.Length == 0)
//        {
//            throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
//        }

//        // Initialize min to MaxValue so every value in the input
//        // is less than this initial value.
//        var min = int.MaxValue;
//        // Initialize max to MinValue so every value in the input
//        // is greater than this initial value.
//        var max = int.MinValue;
//        foreach (var i in input)
//        {
//            if (i < min)
//            {
//                min = i;
//            }
//            if (i > max)
//            {
//                max = i;
//            }
//        }
//        return (min, max);
//    }
//}




////(double, int) t1 = (4.5, 3);
////Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
////// Output:
////// Tuple with elements 4.5 and 3.

////(double Sum, int Count) t2 = (4.5, 3);
////Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
////// Output:
////// Sum of 3 elements is 4.5.
////(double, int) t = (4.5, 3);
////Console.WriteLine(t.ToString());
////Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");
////// Output:
////// (4.5, 3)
////// Hash code of (4.5, 3) is 718460086.


////var t = (Sum: 4.5, Count: 3);
////Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");

////(double Sum, int Count) d = (4.5, 3);
////Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

////Beginning with C# 12, you can specify an alias for a tuple type with a using directive.
////following example adds a global using alias for a tuple type with two integer values for an allowed Min and Max value:

////C#

////Copy
////global using BandPass = (int Min, int Max);
////After declaring the alias, you can use the BandPass name as an alias for that tuple type:

////C#

////Copy
////BandPass bracket = (40, 100);
////Console.WriteLine($"The bandpass filter is {bracket.Min} to {bracket.Max}");