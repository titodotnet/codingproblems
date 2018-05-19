using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Search
{
    class BinarySearchInCircularSortedArray
    {
        public static void Main()
        {
            SearchInCircularSortedArrayProcessor processor = new SearchInCircularSortedArrayProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class SearchInCircularSortedArrayProcessor
    {
        public void Process()
        {
            int[] array = { 25, 27, 28, 29, 2, 5, 7, 9, 11, 13, 15, 17, 22, 24 };

            Console.WriteLine($"search 22 in rotated array: {SearchInRotatedArray(array, 22)}");
        }

        /// <remarks>
        /// Case 1: A[mid] == item then return mid
        /// Case 2: A[mid] <= A[end] then 
        ///          if item > A[mid] && item <= A[end] then
        ///             start=mid+1
        ///          else
        ///             end=mid-1
        /// Case 3: A[start] <= A[mid] then
        ///         if item < A[mid] && item >= A[start] then
        ///             end=mid-1
        ///         else
        ///             start=mid+1
        /// </remarks>
        private int SearchInRotatedArray(int[] array, int itemToBeSearched)
        {
            int start = 0;
            int end = array.Length - 1;
            int totalElements = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (array[mid] == itemToBeSearched)
                {
                    return mid;
                }

                if (array[mid] <= array[end])
                {
                    if (itemToBeSearched > array[mid] && itemToBeSearched <= array[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else if (array[mid] >= array[start])
                {
                    if (itemToBeSearched < array[mid] && itemToBeSearched >= array[start])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}
