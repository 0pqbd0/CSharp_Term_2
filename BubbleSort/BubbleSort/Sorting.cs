using System;

namespace Sorting;

public static class Sort
{
    /// <summary>
    /// Sorting an integer array using the bubble sort algorithm
    /// </summary>
    /// <param name="array"></param>
    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var temporary = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temporary;
                }
            }
        }
    }
}
