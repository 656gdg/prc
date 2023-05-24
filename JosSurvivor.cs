// In this kata you have to correctly return who is the "survivor", ie: the last element of a Josephus permutation.
// Notes and tips: using the solution to the other kata to check your function may be helpful,
// but as much larger numbers will be used, using an array/list to compute the number of the survivor may be too slow; you may assume that both n and k will always be >=1.

public static int JosSurvivor(int n, int k)
{
    int sur = 0;

    for (int i = 1; i <= n; i++)
    {
        sur = (sur + k) % i;
    }
    return sur + 1;
}