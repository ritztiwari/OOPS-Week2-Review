using System;
namespace String_Question
{
    class Problem
    {

        public static void Main(string[] args)
        {
            String str = "aab";
            Console.WriteLine(CutRequired(str));

        }
        public static bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }
            return true;
        }

        static int CutRequired(string s)
        {
            int n = s.Length;
            // if string is already palindrome then no cuts required
            if (IsPalindrome(s))
            {
                return 0;
            }
            for (int i = 1; i < n; i++)
            {
                string left = s.Substring(0, i);
                string right = s.Substring(i);
                if (IsPalindrome(left) && IsPalindrome(right))
                {
                    return 1;
                }
            }
            return n - 1;
        }

    }

}