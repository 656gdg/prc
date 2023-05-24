// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.
// The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

public static int DuplicateCount(string str)
{
    string f = "";
    int count = 0;

    str = str.ToLower();
    for (int i = 0; i < str.Length;)
    {
        if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
        {
            i++;
        }
        else
        {
            count++;
            char[] gg = new char[1];
            gg[0] = str[i];
            f = new string(gg);
            Console.Write(f);
            str = str.Replace(f, string.Empty);
        }
    }
    return count;
}