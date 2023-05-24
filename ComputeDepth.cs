// The depth of an integer n is defined to be how many multiples of n it is necessary to compute before all 10 digits have appeared at least once in some multiple.
// Looking at the above table under digits column you can find all the digits from 0 to 9, Hence it required 9 multiples of 42 to get all the digits. So the depth of 42 is 9.
// Write a function named computeDepth which computes the depth of its integer argument.Only positive numbers greater than zero will be passed as an input.

public static int ComputeDepth(int n)
{
    bool[] num = new bool[10];
    bool finCheck;
    int final = 1;

    while (true)
    {
        int res = n * final;
        while (res > 0)
        {
            int ch = res % 10;
            res /= 10;
            if (!num[ch])
            {
                num[ch] = true;
            }
        }
        finCheck = true;
        foreach (bool fl in num)
        {
            if (!fl)
                finCheck = false;
        }
        if (finCheck) break;
        final++;
    }
    return final;
}