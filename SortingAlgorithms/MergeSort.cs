using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] data)
        {
            Sort(data, 0, data.Length - 1);
        }

        private static void Sort(int[] data, int startPos, int endPos)
        {
            if ((endPos - startPos) <= 0) return;

            var middlePos = (endPos + startPos) / 2;

            Sort(data, startPos, middlePos);
            Sort(data, middlePos + 1, endPos);

            Merge(data, startPos, middlePos, endPos);
        }

        private static void Merge(int[] data, int startPos, int midPos, int endPos)
        {
            List<int> result = new List<int>();
            int left = startPos;
            int right = midPos + 1;

            while(left <= midPos && right <= endPos)
            {
                if(data[left] < data[right])
                {
                    result.Add(data[left]);
                    left++;
                }
                else
                {
                    result.Add(data[right]);
                    right++;
                }
            }

          
            while(left <= midPos)
            {
                result.Add(data[left]);
                left++;
            }

            while (right <= endPos)
            {
                result.Add(data[right]);
                right++;
            }

            for (int i = 0; i < result.Count; i++)
            {
                data[startPos + i] = result[i];
            }

        }
    }
}
