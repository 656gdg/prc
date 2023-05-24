// Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
// Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
// If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

public static string Order(string words)
{
    var d = new Dictionary<string, int>();
    string dig;

    foreach (var word in words.Split())
    {
        var num = 0;
        dig = null;
        foreach (var c in word)
        {
            // dig = null;
            if (char.IsDigit(c))
            {
                dig = dig + c.ToString();
            }
        }
        if (dig != null)
        {
            num = int.Parse(dig);
        }
        d.Add(word, num);
    }
    return string.Join(" ", d.OrderBy(x => x.Value).Select(x => x.Key).ToList());
}