using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Sorting
{
    class MergeSort
    {
        public static void Main()
        {
            MergeSortProcessor processor = new MergeSortProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class MergeSortProcessor
    {
        int[] itemsToBeSorted;
        public void Process()
        {
            Initialize();

            Console.WriteLine("Unsorted elements......");
            Print(this.itemsToBeSorted);

            var sortedItems = MergeSort(this.itemsToBeSorted);

            Console.WriteLine("Sorted elements......");
            Print(sortedItems);
        }

        private void Initialize()
        {
            itemsToBeSorted = new int[] { 25, 9, 28, 5, 20, 15, 11 };
        }

        private int[] MergeSort(int[] itemsToBeSorted)
        {
            if (itemsToBeSorted.Length <= 1)
            {
                return itemsToBeSorted;
            }

            int midIndex = itemsToBeSorted.Length / 2;
            int[] leftPart = new int[midIndex];
            int rightPartLength = itemsToBeSorted.Length - midIndex;
            int[] rightPart = new int[rightPartLength];
            Array.Copy(itemsToBeSorted, 0, leftPart, 0, midIndex);
            Array.Copy(itemsToBeSorted, midIndex, rightPart, 0, rightPartLength);

            MergeSort(leftPart);
            MergeSort(rightPart);

            Merge(leftPart, rightPart, itemsToBeSorted);

            return itemsToBeSorted;
        }

        private void Merge(int[] leftPart, int[] rightPart, int[] target)
        {
            int ln = leftPart.Length;
            int rn = rightPart.Length;
            int tn = target.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < ln && j < rn)
            {
                if (leftPart[i] < rightPart[j])
                {
                    target[k] = leftPart[i];
                    i++;
                }
                else
                {
                    target[k] = rightPart[j];
                    j++;
                }
                k++;
            }

            while (i < ln)
            {
                target[k] = leftPart[i];
                i++;
                k++;
            }

            while (j < rn)
            {
                target[k] = rightPart[j];
                j++;
                k++;
            }

        }

        private void Print(int[] itemsToPrint)
        {
            foreach (var item in itemsToPrint)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}
