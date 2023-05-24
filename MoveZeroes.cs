// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

public static int[] MoveZeroes(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0) continue;
        arr[count] = arr[i];
        count++;
    }
    for (int i = count; i < arr.Length; i++)
    {
        arr[i] = 0;
    }
    return arr;
}