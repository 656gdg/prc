/*
Given an integer x, return true if x is a 
palindrome
, and false otherwise.
*/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        string num = Convert.ToString(x);
        int i = 0;
        int j = num.Length - 1;
        while (i < j)
        {
            if (num[i++] != num[j--]) return false;
        }
        return true;
    }
}