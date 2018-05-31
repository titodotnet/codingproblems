using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{

    class MaxDiffStockSingleSell
    {
        public static void Main()
        {
            MaxDiffStockSingleSellProcessor processor = new MaxDiffStockSingleSellProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    // Given an array represents cost of a stock on each day. You are allowed to buy and sell the stock only once. 
    // Maximum difference between two elements such that larger element appears after the smaller number
    class MaxDiffStockSingleSellProcessor
    {
        public void Process()
        {
            int[] arrary = { 7, 9, 5, 6, 3, 2 };
            Console.WriteLine($"Maximum difference / profit is: {FindMaxDifference(arrary)} ");
        }


        private int FindMaxDifference(int[] array)
        {
            int maxDiff = array[1] - array[0];
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] - minValue) > maxDiff)
                {
                    maxDiff = array[i] - minValue;
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return maxDiff;
        }
    }
}
