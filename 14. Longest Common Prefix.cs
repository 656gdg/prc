/*
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".
*/
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        int minLength = 200;
        int p = 0;

        if (strs == null || strs.Length == 0)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        foreach (string s in strs)
        {
            minLength = Math.Min(minLength, s.Length);
        }

        char[] prefix = new char[minLength];

        while (p < prefix.Length)
        {
            char ch = strs[0][p];
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i][p] != ch)
                {
                    return new string(prefix, 0, p);
                }
            }
            prefix[p] = ch;
            p++;
        }
        return new string(prefix);
    }
}