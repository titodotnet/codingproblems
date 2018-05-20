using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class LargestSumContiguousSubarray
    {
        public static void Main()
        {
            LargestSumContiguousSubarrayProcessor processor = new LargestSumContiguousSubarrayProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class LargestSumContiguousSubarrayProcessor
    {
        public void Process()
        {
            int[] array = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine($"Large sum contiguous subarray is: {MaxSubarraySum(array)}");
        }

        /// <remarks>
        /// Below idea is an extractfrom Kadane's Algorithm. 
        /// </remarks>
        private int MaxSubarraySum(int[] array)
        {
            int overallMaxSum = array[0];
            int currentMaxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                currentMaxSum = Math.Max(array[i], currentMaxSum + array[i]);
                overallMaxSum = Math.Max(currentMaxSum, overallMaxSum);
            }

            return overallMaxSum;
        }
    }
}
