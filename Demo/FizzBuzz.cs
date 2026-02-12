using System;
namespace Demo{
    public class FizzBuzz
    {
        public static String run(int num)
        {
            string result = num % 3 == 0 ? "Fizz" : "";
            result += num % 5 == 0 ? "Buzz" : "";

            return num % 3 != 0 && num % 5 != 0 ? num.ToString() : result;


        }
    }
}