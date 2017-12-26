using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsOfProgrammingInterviews.Arrays
{
    //  Problem 6.1, pg. 46: Write a function that takes an array A of length n and an index i into
    //      A, and rearranges the elements such that all elements less than A[i] appear first, followed by
    //      elements equal to A[i], followed by elements greater than A[i]. Your algorithm should have
    //      O(1) space complexity and O(n) time complexity.


    class ReorderArrayByPivot
    {
        public static void Main()
        {
            int[] sourceArray = { 4, 9, 55, 23, 1, 42, 77, 15, 35, 67, 92, 7 };
            Partition(sourceArray, 7);
            Console.ReadKey();
        }

        private static void Partition(int[] sourceArrary, int pivotIndex)
        {
            Console.WriteLine("Printing source array....");
            PrintArray(sourceArrary);

            // [0..p] => small group
            // [p+1..q] => equal group
            // [r..n-1] => large group
            // [j..r] => unordered group

            int p = -1;
            int q = -1;
            int r = sourceArrary.Length - 1; // consider corner case scenario - where no element is greater than pivot element. No action needed (q and r will have same value)
            int j = 0;

            int pivotElement = sourceArrary[pivotIndex];

            while (j <= r)
            {
                if (sourceArrary[j] < pivotElement)
                {
                    SwapElement(sourceArrary, ++p, j);
                    q++;
                    j++;
                }
                else if (sourceArrary[j] == pivotElement)
                {
                    q++;
                    j++;
                }
                else
                {
                    SwapElement(sourceArrary, j, r--);
                }                
            }

            Console.WriteLine("Printing rearranged array elements....");
            PrintArray(sourceArrary);
        }

        private static void SwapElement(int[] arrayToHaveElementsSwapped, int swapIndex1, int swapIndex2)
        {
            int temp = arrayToHaveElementsSwapped[swapIndex1];
            arrayToHaveElementsSwapped[swapIndex1] = arrayToHaveElementsSwapped[swapIndex2];
            arrayToHaveElementsSwapped[swapIndex2] = temp;
        }

        private static void PrintArray(int[] arrayToBePrinted)
        {
            foreach (var item in arrayToBePrinted)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}
