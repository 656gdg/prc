/*
Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
You have the following three operations permitted on a word:
Insert a character
Delete a character
Replace a character
*/
public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] arr = new int[word1.Length + 1, word2.Length + 1];
        for (int i = 0; i <= word1.Length; i++)
        {
            for (int j = 0; j <= word2.Length; j++)
            {
                if (i == 0)
                {
                    arr[i, j] = j;
                }
                else if (j == 0)
                {
                    arr[i, j] = i;
                }
                else if (word1[i - 1] != word2[j - 1])
                {
                    arr[i, j] = 1 + Math.Min(arr[i - 1, j - 1], Math.Min(arr[i, j - 1], arr[i - 1, j]));
                }
                else arr[i, j] = arr[i - 1, j - 1];
            }
        }
        return arr[word1.Length, word2.Length];
    }
}