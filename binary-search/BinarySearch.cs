using System;

public static class BinarySearch
{
    public static int Find(int[] array, int query)
    // The thing is, there is already a built in method to do this:
        // => Array.IndexOf(array, value);
    // ... But I think writing one manually is meant to be the point of this,
    // so I reckon I'll break out the C fundamentals:

    {
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == query) return i;
        }
        return -1;
    }
}
