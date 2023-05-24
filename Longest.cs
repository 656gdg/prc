// Take 2 strings s1 and s2 including only letters from a to z.
// Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

public static string Longest(string s1, string s2)
{
    string l1 = new string(s1.Distinct().ToArray());
    string l2 = new string(s2.Distinct().ToArray());
    string final = string.Concat(l1, l2);

    return string.Join("", final.Distinct().OrderBy(l => l));
}