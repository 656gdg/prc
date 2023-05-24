// Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels for this Kata (but not y).
// The input string will only consist of lower case letters and/or spaces.

public static int GetVowelCount(string str)
{
    int vowelCount = 0;
    foreach (char ch in str.ToLower())
    {
        if ("aeiou".Contains(ch))
        {
            vowelCount++;
        }
    }
    return vowelCount;
}