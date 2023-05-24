/*
Given a string s consisting of words and spaces, return the length of the last word in the string.
A word is a maximal substring consisting of non-space characters only.
*/
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string word = s.TrimEnd(' ').Split(' ').Last();
        return word.Length;
    }
}