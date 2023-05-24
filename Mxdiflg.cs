﻿// You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. Let x be any string in the first array and y be any string in the second array.
// Find max(abs(length(x) − length(y)))
// If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).
// input : 2 strings with substrings separated by ',' output: number as a string

public static int Mxdiflg(string[] a1, string[] a2)
{
    if ((a1.Length == 0 || a2.Length == 0)) return -1;
    else
    {
        int arr1 = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
        int arr2 = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));

        return Math.Max(arr1, arr2);
    }
}