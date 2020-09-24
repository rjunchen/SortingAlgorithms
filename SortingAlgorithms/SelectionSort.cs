using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int smallestNumberIndex = i;

                for (int j = i ; j < data.Length; j++)
                {
                    if (data[j] < data[smallestNumberIndex]) smallestNumberIndex = j;
                }

                if (smallestNumberIndex != i) data.Swap(i, smallestNumberIndex);
            }
        }
    }
}
