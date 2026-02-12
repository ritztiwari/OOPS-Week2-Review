using System;

internal class FizzBuzz
{
    internal static String run(int num)
    {
        string result=num%3==0 ? "Fizz" : "";
        result+=num%5==0 ? "Buzz" : "";

        return  num%3!=0 && num%5!=0 ? num.ToString() : result;

    }

}