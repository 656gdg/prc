/*
Alice has n candies, where the ith candy is of type candyType[i]. Alice noticed that she started to gain weight, so she visited a doctor.
The doctor advised Alice to only eat n / 2 of the candies she has (n is always even). Alice likes her candies very much, and she wants to eat the maximum number of different types of candies while still following the doctor's advice.
Given the integer array candyType of length n, return the maximum number of different types of candies she can eat if she only eats n / 2 of them.
*/
public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        int max = candyType.Length / 2;
        List<int> candyList = new List<int>();

        foreach (var candy in candyType)
        {
            if (!candyList.Contains(candy))
            {
                candyList.Add(candy);
            }
        }
        return Math.Min(candyList.Count, max);
    }
}