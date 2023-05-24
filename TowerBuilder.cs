// Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

public static string[] TowerBuilder(int nFloors)
{
    string[] final = new string[nFloors];
    int pad;

    for (int i = 1; i < nFloors * 2; i += 2)
    {
        pad = (nFloors * 2 - i) / 2;
        final[i / 2] = new string(' ', pad) + new string('*', i) + new string(' ', pad);
    }
    return final;
}