// Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

public static string RepeatStr(int n, string s)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < n; i++)
    {
        sb.Append(s);
    }
    return sb.ToString();
}