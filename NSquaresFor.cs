// The task is simply stated. Given an integer n (3 < n < 109), find the length of the smallest list of perfect squares which add up to n.
// Come up with the best algorithm you can; you'll need it!

public static int NSquaresFor(int n)
{
    if (Math.Pow((int)Math.Sqrt(n), 2) != n)
    {
        for (int i = 0; i < (int)Math.Sqrt(n) + 1; i++)
        {
            int sq = (int)Math.Sqrt(n - Math.Pow(i, 2));
            if (sq * sq == n - Math.Pow(i, 2))
            {
                return 2;
            }
        }
        while (n % 4 == 0)
        {
            n /= 4;
        }
        if (n % 8 != 7)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
    return 1;
}