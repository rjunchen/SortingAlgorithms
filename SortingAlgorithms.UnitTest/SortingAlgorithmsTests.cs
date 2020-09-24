using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SortingAlgorithms.UnitTest
{
    public class SortingAlgorithmsTests
    {
        private static readonly int[] largeData = SortingAlgorithmsTests.GenerateRangedRandomNumber(1000);

        private static int[] GenerateRangedRandomNumber(int nums)
        {
            var array = Enumerable.Range(0, nums).ToArray();
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                var randNum = random.Next(0, nums);
                array.Swap(i, randNum);
            }
            return array;
        }


        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { new int[] { 2, 5, 9, 1, 4, 8, 6, 7, 0, 3 } };
            yield return new object[] { new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            yield return new object[] { new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 } };
            yield return new object[] { largeData.DeepCopy() };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void SelectionSort_Sort_Success(int[] data)
        {
            SelectionSort.Sort(data);
            Assert.True(data.IsSorted());
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void BubbleSort_Sort_Success(int[] data)
        {
            BubbleSort.Sort(data);
            Assert.True(data.IsSorted());
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void InsertionSort_Sort_Success(int[] data)
        {
            InsertionSort.Sort(data);
            Assert.True(data.IsSorted());
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MergeSort_Sort_Success(int[] data)
        {
            MergeSort.Sort(data);
            Assert.True(data.IsSorted());
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void QuickSort_Sort_Success(int[] data)
        {
            QuickSort.Sort(data);
            Assert.True(data.IsSorted());
        }
    }
}
