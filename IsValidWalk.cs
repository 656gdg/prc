// You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block,
// so create a function that will return true if the walk the app gives you will take you exactly ten minutes(you don't want to be early or late!)
// and will, of course, return you to your starting point. Return false otherwise.

public static bool IsValidWalk(string[] walk)
{
    int x = 0;
    int y = 0;
    if (walk.Length != 10) return false;

    for (int des = 0; des < walk.Length; des++)
    {
        switch (walk[des])
        {
            case "n": { y++; break; }
            case "s": { y--; break; }
            case "w": { x++; break; }
            case "e": { x--; break; }
        }
    }
    if (x == 0 && y == 0) return true;
    else return false;
}