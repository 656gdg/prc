// Given a non - empty array of integers, return the result of multiplying the values together in order.

public static int Grow(int[] x)
{
    int result = 1;
    for (int i = 0; i < x.Length; i++)
    {
        result *= x[i];
    }
    return result;
}