// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
{
    T current = default;

    foreach (var ch in iterable)
    {
        if (!ch.Equals(current))
        {
            yield return ch;
            current = ch;
        }
    }
}