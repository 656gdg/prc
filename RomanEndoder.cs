// Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
// Remember that there can't be more than 3 identical symbols in a row.

public static string RomanEndoder(int n)
{
    int[] num = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] let = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    string val = "";

    for (int i = 0; i < num.Length && n != 0; i++)
    {
        while (n >= num[i])
        {
            n = n - num[i];
            val = val + let[i];
        }
    }
    return val;
}