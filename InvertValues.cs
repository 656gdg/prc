// Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

public static int[] InvertValues(int[] input)
{
    return input.Select(n => -n).ToArray();
}