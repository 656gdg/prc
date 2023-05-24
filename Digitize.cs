// Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

public static long[] Digitize(long n)
{
    return n.ToString()
      .ToCharArray()
      .Select(c => long.Parse(c.ToString()))
      .Reverse()
      .ToArray();
}