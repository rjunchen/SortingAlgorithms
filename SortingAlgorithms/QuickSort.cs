using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] data)
        {
            Sort(data, 0, data.Length - 1);
        }

        private static void Sort(int[] data, int startPos, int endPos)
        {
            if (startPos >= endPos) return;

            int pivotIndex = Partition(data, startPos, endPos);

            Sort(data, startPos, pivotIndex - 1);
            Sort(data, pivotIndex + 1, endPos);
        }

        private static int Partition(int[] data, int startPos, int endPos)
        {
            int pivot = data[endPos];

            int currentOrderedIndex = startPos - 1;

            for (int i = startPos; i <= endPos; i++)
            {
                if (data[i] < pivot)
                {
                    currentOrderedIndex++;
                    data.Swap(currentOrderedIndex, i);
                }
            }

            data.Swap(currentOrderedIndex + 1, endPos);

            return currentOrderedIndex + 1;
        }
    }
}
