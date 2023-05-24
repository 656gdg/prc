// Given the string representations of two integers, return the string representation of the sum of those integers.
// A string representation of an integer will contain no characters besides the ten numerals "0" to "9".

public static string sumStrings(string a, string b)
{
    string final;

    if (a == string.Empty) a = "0";
    if (b == string.Empty) b = "0";
    BigInteger res = BigInteger.Parse(a) + BigInteger.Parse(b);
    final = Convert.ToString(res);
    return final;
}