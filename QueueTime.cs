// There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!

public static long QueueTime(int[] customers, int n)
{
    int[] res = new int[n];

    for (int i = 0; i < customers.Length; i++)
    {
        res[0] += customers[i];
        Array.Sort(res);
    }
    //Array.Sort(res);
    return res[n - 1];
}