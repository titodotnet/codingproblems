using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Search
{
    class BinarySearchCountOccurence
    {
        public static void Main()
        {
            BinarySearchCountOccurenceProcessor processor = new BinarySearchCountOccurenceProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BinarySearchCountOccurenceProcessor
    {
        public void Process()
        {
            int[] array = { 2, 5, 7, 9, 11, 13, 15, 17, 22, 22, 22, 22, 24, 25, 27, 28, 29 };

            Console.WriteLine($"count of occurence of 22: {CountOccurence(array, 22)}");
        }

        private int CountOccurence(int[] array, int itemToBeSearched)
        {
            BinarySearchFindFirstLastOccurenceProcessor firstLastOccurence = new BinarySearchFindFirstLastOccurenceProcessor();

            int firstOccurence = firstLastOccurence.FindFirstOrLastOccurence(array, itemToBeSearched, true);
            int lastOccurence = firstLastOccurence.FindFirstOrLastOccurence(array, itemToBeSearched, false);

            return lastOccurence - firstOccurence + 1;
        }
    }
}
