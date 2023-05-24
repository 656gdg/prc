// The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string.
// Ignore capitalization when determining if a character is a duplicate.

public static string DuplicateEncode(string word)
{
    string result = word.ToLower();
    string res = null;

    foreach (char ch in result)
    {
        res += result.Count(x => x == ch) > 1 ? ")" : "(";
    }
    return res;
}