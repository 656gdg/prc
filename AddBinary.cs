
// Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
// The binary number returned should be a string.

public static string AddBinary(int a, int b)
{
    int c;
    string res = null;

    c = a + b;
    for (int i = 0; c > 0; i++)
    {
        res = c % 2 + res;
        c = c / 2;
    }
    return res;
}