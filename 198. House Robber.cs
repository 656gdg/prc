/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
*/
public class Solution
{
    public int Rob(int[] nums)
    {
        int value;
        int h1 = 0;
        int h2 = 0;

        foreach (var money in nums)
        {
            value = Math.Max(h1, h2 + money);
            h2 = h1;
            h1 = value;
        }
        return h1;
    }
}