using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Sorting
{
    class BubbleSort
    {
        public static void Main()
        {
            BubbleSortProcessor processor = new BubbleSortProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BubbleSortProcessor
    {
        int[] itemsToBeSorted;
        public void Process()
        {
            Initialize();

            Console.WriteLine("Unsorted elements......");
            Print(this.itemsToBeSorted);

            BubbleSort(this.itemsToBeSorted);

            Console.WriteLine("Sorted elements......");
            Print(this.itemsToBeSorted);
        }

        private void Initialize()
        {
            itemsToBeSorted = new int[] { 25, 9, 28, 5, 20, 15, 11 };
        }

        public void BubbleSort(int[] itemsToSort)
        {
            int n = itemsToBeSorted.Length;

            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = 0; j <= n - i - 2; j++)
                {
                    if (itemsToSort[j] > itemsToSort[j+1])
                    {
                        var temp = itemsToSort[j];
                        itemsToSort[j] = itemsToSort[j + 1];
                        itemsToSort[j + 1] = temp;
                    }
                }
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
