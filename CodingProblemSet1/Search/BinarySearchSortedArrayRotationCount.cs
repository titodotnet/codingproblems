using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Search
{
    class BinarySearchSortedArrayRotationCount
    {
        public static void Main()
        {
            SortedArrayRotationCountProcessor processor = new SortedArrayRotationCountProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class SortedArrayRotationCountProcessor
    {
        public void Process()
        {
            int[] array = { 25, 27, 28, 29, 2, 5, 7, 9, 11, 13, 15, 17, 22, 24 };

            Console.WriteLine($"count of array rotation: {CountSortedArrayRotation(array)}");
        }

        /// <remarks>
        /// Case 1: A[start] <= A[end] then return start
        /// Case 2: A[mid] <= A[next] && A[mid] <= A[prev] then return mid
        ///          prev=(mid+N-1)%N
        ///          next=(mid+1)%N
        /// Case 3: if A[mid] <= A[end] (means right is sorted) then end=mid-1
        /// Case 4: if A[start] <= A[mid] (means left is sorted) then start=mid+1
        /// </remarks>
        private int CountSortedArrayRotation(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            int totalElements = array.Length - 1;

            while (start <= end)
            {
                if (array[start] <= array[end])
                {
                    return start;
                }

                int mid = start + (end - start) / 2;
                int previous = (mid - 1 + totalElements) % totalElements;
                int next = (mid + 1) % totalElements;

                if (array[mid] <= array[next] && array[mid] <= array[previous])
                {
                    return mid;
                }
                else if (array[mid] <= array[end])
                {
                    end = mid - 1;
                }
                else if (array[start] <= array[mid])
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}
