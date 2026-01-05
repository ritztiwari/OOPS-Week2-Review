/*Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,4,4,5,6,7] might become:
[4,5,6,7,0,1,4] if it was rotated 4 times.
[0,1,4,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
Given the sorted rotated array nums that may contain duplicates, return the minimum element of this array.
You must decrease the overall operation steps as much as possible.
 
Example 1:
Input: nums = [1,3,5]
Output: 1
Example 2:
Input: nums = [2,2,2,0,1]
Output: 0*/





using System;

public class FindingMinimum
{
	public void Class1()
	{
		Console.WriteLine($"Enter a number : ");
		int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter a sorted rotated array : ");
		int[] nums = new int[n];
		for(int i = 0; i < n; i++)
		{
			nums[i] = Convert.ToInt32(Console.ReadLine());
        }
		int left = 0;
		int right = n - 1;
		while(left < right)
		{
			int mid = left + (right - left) / 2;
			if (nums[mid] > nums[right])
			{
				left = mid + 1;
			}
			else if (nums[mid] < nums[right])
			{
				right = mid;
			}
			else
			{
				right--;
			}
		}

		Console.WriteLine($"The Min Value is : {nums[right]}");
    }
}
