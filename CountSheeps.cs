// Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).
// Hint: Don't forget to check for bad values like null/undefined

public static int CountSheeps(bool[] sheeps)
{
    int res = 0;
    foreach (bool b in sheeps)
    {
        if (b.ToString() != null && b != false)
        {
            res++;
        }
    }
    return res;
}