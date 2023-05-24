// Could you make a program that 
// - makes this string uppercase
// - gives it sorted in alphabetical order by last name.
// When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.
// It can happen that in two distinct families with the same family name two people have the same first name too.

public static string Meeting(string s)
{
    return string.Concat(s.ToUpper()
                         .Split(";")
                         .Select(x => $"({string.Join(", ", x.Split(':').Reverse())})")
                         .OrderBy(f => f));
}