// There was a test in your class and you passed it. Congratulations!
// But you're an ambitious person. You want to know if you're better than the average student in your class.
// You receive an array with your peers' test scores. Now calculate the average and compare your score!
// Return True if you're better, else False!

public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
{
    int avg;
    int sum = 0;

    for (int i = 0; i < ClassPoints.Length; i++)
    {
        sum += ClassPoints[i];
    }
    avg = sum / ClassPoints.Length;

    if (avg > YourPoints) return false;
    else return true;
}