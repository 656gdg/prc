// There is an array with some numbers. All numbers are equal except for one. Try to find it! 
// The tests contain some very huge arrays, so think about performance.

public static int GetUnique(IEnumerable<int> numbers)
{
    return numbers
      .GroupBy(x => x)
      .Single(x => x.Count() == 1)
      .Key;
}