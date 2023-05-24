// Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
// Note: The function accepts an integer and returns an integer

public static int SquareDigits(int n)
{
    string res = "";

    foreach (char ch in n.ToString())
    {
        double str = int.Parse(ch.ToString());
        res += Math.Pow(str, 2);
    }
    return Convert.ToInt32(res);
}