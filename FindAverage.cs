// Write a function which calculates the average of the numbers in a given list.
// Note: Empty arrays should return 0.

public static double FindAverage(double[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }
    else return array.Average();
}