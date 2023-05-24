// Create a function that takes a string and returns the string ciphered with Rot13.
// If there are numbers or special characters included in the string, they should be returned as they are.
// Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

public static string Rot13(string message)
{
    char[] mes = message.ToCharArray();

    for (int i = 0; i < mes.Length; i++)
    {
        int ch = (int)mes[i];
        if ('a' <= ch && ch <= 'm' || 'A' <= ch && ch <= 'M')
        {
            ch += 13;
        }
        else if ('n' <= ch && ch <= 'z' || 'N' <= ch && ch <= 'Z')
        {
            ch -= 13;
        }
        mes[i] = (char)ch;
    }
    return new string(mes);
}