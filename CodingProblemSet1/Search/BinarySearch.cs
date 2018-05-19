using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Search
{
    class BinarySearch
    {
        public static void Main()
        {
            BinarySearchProcessor processor = new BinarySearchProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BinarySearchProcessor
    {

        public void Process()
        {
            int[] array = { 2, 5, 7, 9, 11, 13, 15, 17, 19, 22, 24, 25, 27, 28, 29 };

            Console.WriteLine($"22 BinarySearchIterative: {BinarySearchIterative(array, 22)}");

            Console.WriteLine($"22 BinarySearchRecursive: {BinarySearchRecursive(array, 22, 0, array.Length - 1)}");
        }


        private int BinarySearchIterative(int[] array, int itemToBeSearched)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (array[mid] == itemToBeSearched)
                {
                    return mid;
                }
                else if (itemToBeSearched < array[mid])
                {
                    end = mid - 1;
                }
                else if (itemToBeSearched > array[mid])
                {
                    start = mid + 1;
                }
            }

            return -1;
        }

        private int BinarySearchRecursive(int[] array, int itemToBeSearched, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = start + (end - start) / 2;

            if (array[mid] == itemToBeSearched)
            {
                return mid;
            }
            else if (itemToBeSearched < array[mid])
            {
                end = mid - 1;
                return BinarySearchRecursive(array, itemToBeSearched, start, end);
            }
            else
            {
                start = mid + 1;
                return BinarySearchRecursive(array, itemToBeSearched, start, end);
            }
        }

    }
}
