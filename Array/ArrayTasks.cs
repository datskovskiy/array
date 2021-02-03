using System;
using System.Linq;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                var invertIndex = nums.Length - 1 - i;

                if (nums[i] % 2 != 0 || nums[invertIndex] % 2 != 0) continue;

                var buffer = nums[i];
                nums[i] = nums[invertIndex];
                nums[invertIndex] = buffer;
            }
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            var result = 0;

            if (nums.Length <= 0) return result;

            var firstOccurrenceOfMaxValue = Array.IndexOf(nums, nums.Max());
            var lastOccurrenceOfMaxValue = Array.LastIndexOf(nums, nums.Max());

            if (firstOccurrenceOfMaxValue != lastOccurrenceOfMaxValue)
                result = lastOccurrenceOfMaxValue - firstOccurrenceOfMaxValue;

            return result;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) return;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j) continue;

                    matrix[i, j] = i < j ? 1 : 0;
                }
            }
        }
    }
}
