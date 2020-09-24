using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class ExtensionMethods
    {
        public static void Swap(this int[] array, int sourcePos, int targetPos)
        {
            if (array == null || array.Length < 2) return;

            var temp = array[sourcePos];
            array[sourcePos] = array[targetPos];
            array[targetPos] = temp;
        }

        public static bool IsSorted(this int[] array)
        {
            if (array == null || array.Length < 2) return true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1]) return false;
            }

            return true;
        }

        public static int[] DeepCopy(this int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }
    }
}
