using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsOfProgrammingInterviews.Arrays
{
    class DeleteValueFromArray
    {
        public static void Main()
        {
            DeleteValueFromArrayProcessor processor = new DeleteValueFromArrayProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class DeleteValueFromArrayProcessor
    {
        public void Process()
        {
            int[] sourceArray = { 4, 9, 55, 23, 1, 42, 77, 15, 35, 67, 23, 92, 7 };
            Console.WriteLine("Source array:");
            PrintArray(sourceArray);

            DeleteValue(sourceArray, 23);
            Console.WriteLine("Updated array:");
            PrintArray(sourceArray);
        }
        private void DeleteValue(int[] array, int valueToBeDeleted)
        {
            int writePointer = 0;

            foreach (var item in array)
            {
                if (!item.Equals(valueToBeDeleted))
                {
                    array[writePointer] = item;
                    writePointer++;
                }
            }
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
