// Given a string of words, you need to find the highest scoring word.
// Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
// You need to return the highest scoring word as a string.
// If two words score the same, return the word that appears earliest in the original string.

public static string High(string s)
{
    int score;
    var words = s.Split();
    var result = new List<int>();

    foreach (string x in words)
    {
        score = 0;
        foreach (char c in x)
        {
            score = score + (int)c - 'a' + 1;
        }
        result.Add(score);
    }
    return words[result.IndexOf(result.Max())];
}