/*
 
 1)Longest Valid Parentheses

Topics
premium lock icon
Companies
Given a string containing just the characters '(' and ')', return the length of the longest valid (well-formed) parentheses substring.

 

Example 1:

Input: s = "(()"
Output: 2
Explanation: The longest valid parentheses substring is "()".
Example 2:

Input: s = ")()())"
Output: 4
Explanation: The longest valid parentheses substring is "()()".
Example 3:

Input: s = ""
Output: 0
 */
using System;
public class ValidParanthesis
{
    public int check(String s)
    {
        int count = 0;
        int top = -1;
        for(int i=0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                ++top;
                
               
            }
            else if(s[i] == ')' && top != -1)
            {
                --top;
                count++;
            }
        }
        return count*2;
    }

}