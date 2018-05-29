using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class IntersectionOfTwoSortedArrays
    {

        public static void Main()
        {
            IntersectionOfTwoSortedArraysProcessor processor = new IntersectionOfTwoSortedArraysProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class IntersectionOfTwoSortedArraysProcessor
    {
        public void Process()
        {
            int[] firstArray = { 1, 2, 3, 6, 6, 6, 6, 8, 10, 20 };
            int[] secondArray = { 4, 5, 6, 11, 15, 20 };


            Console.WriteLine("Print first array");
            PrintArray(firstArray);

            Console.WriteLine("Print second array");
            PrintArray(secondArray);

            var result = IntersectSortedArrays(firstArray, secondArray);

            Console.WriteLine("Print resultant array");
            PrintArray(result);
        }

        /// <remarks>
        /// Duplicates to be eliminated.
        /// </remarks>
        private int[] IntersectSortedArrays(int[] firstArray, int[] secondArray)
        {
            List<int> resultant = new List<int>();

            int i = 0;
            int j = 0;

            while (i < firstArray.Length && j < secondArray.Length)
            {
                if ((i == 0 || firstArray[i] != firstArray[i - 1]) && firstArray[i] == secondArray[j])
                {
                    resultant.Add(firstArray[i]);
                    i++;
                    j--; // TODO: Bug fix: should be j++
                }
                else if (firstArray[i] > secondArray[j])
                {
                    j++;
                }
                else // Case: (firstArray[i] < secondArray[j]) or the race condition firstArray[i] == firstArray[i - 1] and firstArray[i] == secondArray[j]
                {
                    i++;
                }
            }

            return resultant.ToArray();
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
