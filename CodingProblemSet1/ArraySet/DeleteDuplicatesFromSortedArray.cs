using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class DeleteDuplicatesFromSortedArray
    {
        public static void Main()
        {
            DeleteDuplicatesFromSortedArrayProcessor processor = new DeleteDuplicatesFromSortedArrayProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class DeleteDuplicatesFromSortedArrayProcessor
    {
        public void Process()
        {
            int[] array = { 2, 3, 5, 5, 7, 11, 11, 11, 13 };
            Console.WriteLine("Original array");
            PrintArray(array);

            DeleteDuplicates(array);
        }

        private void DeleteDuplicates(int[] array)
        {
            int writerIndex = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    array[writerIndex] = array[i];
                    writerIndex++;
                }
            }

            while (writerIndex <= array.Length - 1)
            {
                array[writerIndex] = 0;
                writerIndex++;
            }

            Console.WriteLine("After deleitng duplicates");

            PrintArray(array);
        }

        private void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine();
        }
    }
}
