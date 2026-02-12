using System;
using System.Collections.Generic;

public class C1
{
    public static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
