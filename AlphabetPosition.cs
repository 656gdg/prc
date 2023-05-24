// In this kata you are required to, given a string, replace every letter with its position in the alphabet.
// If anything in the text isn't a letter, ignore it and don't return it.

public static string AlphabetPosition(string text)
{
    string res = "";

    foreach (char ch in text.ToLower())
    {
        if (char.IsLetter(ch))
        {
            res += ch - 'a' + 1 + " ";
        }
    }
    return res.TrimEnd();
}