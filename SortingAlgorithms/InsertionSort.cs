using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = i ; j > 0; j--)
                {
                    if (data[j] < data[j - 1]) data.Swap(j, j - 1);
                }
            }
        }
    }
}
