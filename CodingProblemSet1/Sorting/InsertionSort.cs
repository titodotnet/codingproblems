using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Sorting
{
    class InsertionSort
    {
        public static void Main()
        {
            InsertionSortProcessor processor = new InsertionSortProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class InsertionSortProcessor
    {
        int[] itemsToBeSorted;
        public void Process()
        {
            Initialize();

            Console.WriteLine("Unsorted elements......");
            Print(this.itemsToBeSorted);

            InsertionSort(this.itemsToBeSorted);

            Console.WriteLine("Sorted elements......");
            Print(this.itemsToBeSorted);
        }


        private void Initialize()
        {
            itemsToBeSorted = new int[] { 25, 9, 28, 5, 20, 15, 11 };
        }

        public void InsertionSort(int[] itemsToSort)
        {
            int n = itemsToBeSorted.Length;

            for (int i = 1; i <= n - 1; i++)
            {
                int value = itemsToSort[i];
                int hole = i;

                while (hole > 0 && itemsToSort[hole - 1] > value)
                {
                    itemsToSort[hole] = itemsToSort[hole - 1];
                    hole--;
                }

                itemsToSort[hole] = value;
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
