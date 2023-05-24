/*
You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.
Find and return the maximum profit you can achieve.
*/
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int grofit = 0;
        int result = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                grofit = prices[i] - min;
                result += grofit;
                min = prices[i];
            }
        }

        return result;
    }
}