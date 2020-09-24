using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] data)
        {
            for (int i = 0; i < data.Length -1 ; i++)
            {
                var swapped = false;

                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        data.Swap(j, j + 1);
                        swapped = true;
                    } 
                }

                if (!swapped) break;
            }
        }
    }
}
