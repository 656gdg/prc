/*
Given a string s, find the length of the longest substring without repeating characters.
*/
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int result = 0;
        List<char> chList = new List<char>();
        char[] chArray = s.ToCharArray();

        foreach (var c in chArray)
        {
            if (!chList.Contains(c))
            {
                chList.Add(c);
            }
            else
            {
                int index = chList.IndexOf(c);
                chList = chList.Skip(index + 1).ToList();
                chList.Add(c);
            }
            if (result < chList.Count)
            {
                result = chList.Count;
            }
            else result = result++;
        }
        return result;
    }
}