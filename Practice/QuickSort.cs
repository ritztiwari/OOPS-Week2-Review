using System;

public class QuickSort
{
    /// <summary>
    /// Sorts an array using the quicksort algorithm.
    /// Time Complexity: O(n log n) on average, O(n²) in worst case
    /// Space Complexity: O(log n) due to recursion stack
    /// </summary>
    public static void Sort(int[] array)
    {
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortRecursive(array, low, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                // Swap array[i] and array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Swap array[i+1] and array[high] (pivot)
        int temp2 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp2;

        return i + 1;
    }

    public static void Main()
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        Sort(numbers);

        Console.WriteLine("\nSorted array:");
        PrintArray(numbers);

        Console.ReadKey();
    }

    private static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
