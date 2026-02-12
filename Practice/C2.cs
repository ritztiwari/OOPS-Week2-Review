using System;
using System.Collections.Generic;

public class ProductCalculator
{
    public static int CalculateProduct(List<int> numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product *= num;
        }
        return product;
    }
}
