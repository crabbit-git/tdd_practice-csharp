using System;

public static class BinarySearch
{
    public static int Find(int[] array, int query)
    {
        Array.Sort(array); // Test pass without it, but should be tested for
        int bottomIndex = 0, midIndex, topIndex = array.Length - 1;
        while (topIndex >= bottomIndex) {
            midIndex = (bottomIndex + topIndex) / 2;
            if (query > array[midIndex]) {
                bottomIndex = midIndex + 1;
            } else if (query < array[midIndex]) {
                topIndex = midIndex - 1;
            } else return midIndex;
        } return -1;
    }
}
