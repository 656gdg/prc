/*
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/
public class Solution
{
    public int ClimbStairs(int n)
    {
        int s1 = 1;
        int s2 = 2;
        int temp;

        if (n == 1)
        {
            return 1;
        }
        for (int i = 3; i <= n; i++)
        {
            temp = s1 + s2;
            s1 = s2;
            s2 = temp;
        }

        return s2;
    }
}