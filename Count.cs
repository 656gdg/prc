// The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
// What if the string is empty? Then the result should be empty object literal, {}.

public static Dictionary<char, int> Count(string str)
{
    Dictionary<char, int> count = new Dictionary<char, int>();

    foreach (char character in str)
    {
        int i = 0;
        count.TryGetValue(character, out i);
        count[character] = i + 1;
    }
    return count;
}