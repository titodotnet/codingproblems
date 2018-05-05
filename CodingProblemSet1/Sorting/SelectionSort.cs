using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Sorting
{
    class SelectionSort
    {
        public static void Main()
        {
            SelectionSortProcessor processor = new SelectionSortProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class SelectionSortProcessor
    {
        int[] itemsToBeSorted;
        public void Process()
        {
            Initialize();

            Console.WriteLine("Unsorted elements......");
            Print(this.itemsToBeSorted);

            SelectionSort(this.itemsToBeSorted);

            Console.WriteLine("Sorted elements......");
            Print(this.itemsToBeSorted);
        }

        private void Initialize()
        {
            itemsToBeSorted = new int[] { 25, 9, 28, 5, 20, 15, 11 };
        }

        private void SelectionSort(int[] itemsToSort)
        {
            int n = itemsToSort.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                int minIndex = i;

                for (int j = i; j <= n - 1; j++)
                {
                    if (itemsToSort[j] < itemsToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }

                var temp = itemsToSort[i];
                itemsToSort[i] = itemsToSort[minIndex];
                itemsToSort[minIndex] = temp;
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
