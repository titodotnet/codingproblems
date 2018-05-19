using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Search
{
    class BinarySearchFindFirstLastOccurence
    {
        public static void Main()
        {
            BinarySearchFindFirstLastOccurenceProcessor processor = new BinarySearchFindFirstLastOccurenceProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BinarySearchFindFirstLastOccurenceProcessor
    {
        public void Process()
        {
            int[] array = { 2, 5, 7, 9, 11, 13, 15, 17, 22, 22, 22, 22, 24, 25, 27, 28, 29 };

            Console.WriteLine($"Find first ocurence of 22: {FindFirstOrLastOccurence(array, 22, true)}");
            Console.WriteLine($"Find last ocurence of 22: {FindFirstOrLastOccurence(array, 22, false)}");

        }

        public int FindFirstOrLastOccurence(int[] array, int itemToBeSearched, bool findFirst)
        {
            int start = 0;
            int end = array.Length - 1;
            int result = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (array[mid] == itemToBeSearched)
                {
                    result = mid;

                    if (findFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
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

            return result;
        }
    }
}
