//using System;

//public class BubbleSort
//{
//    /// <summary>
//    /// Sorts an array using the bubble sort algorithm.
//    /// Time Complexity: O(n²) in worst and average cases, O(n) in best case
//    /// Space Complexity: O(1)
//    /// </summary>
//    public static void Sort(int[] array)
//    {
//        int n = array.Length;

//        for (int i = 0; i < n - 1; i++)
//        {
//            bool swapped = false;

//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    // Swap elements
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                    swapped = true;
//                }           
//            }

//            // Optimization: if no swaps occurred, array is sorted
//            if (!swapped)
//                break;
//        }
//    }

//    public static void Main()
//    {
//        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

//        Console.WriteLine("Original array:");
//        PrintArray(numbers);

//        Sort(numbers);

//        Console.WriteLine("\nSorted array:");
//        PrintArray(numbers);

//        Console.ReadKey();
//    }

//    private static void PrintArray(int[] array)
//    {
//        foreach (int num in array)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();
//    }
//}
