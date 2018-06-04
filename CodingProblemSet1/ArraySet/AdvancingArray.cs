using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class AdvancingArray
    {
        public static void Main()
        {
            AdvancingArrayProcessor processor = new AdvancingArrayProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    // Program which takes array of n integers, where A[i] denotes the maximum you can advance from index i, and returns whether it is possible
    // to advance to the last index starting from the begining of the array.
    class AdvancingArrayProcessor
    {
        public void Process()
        {
            int[] array = { 3, 3, 1, 0, 2, 0, 1 };

            PrintArray(array);

            Console.WriteLine($"Can the above array reach end: {CanReachEnd(array)}");
        }

        private bool CanReachEnd(int[] array)
        {
            int farthestReachSoFar = 0;
            int endIndex = array.Length - 1;

            for (int i = 0; i <= farthestReachSoFar && farthestReachSoFar <= endIndex; i++)
            {
                farthestReachSoFar = Math.Max(farthestReachSoFar, i + array[i]);
            }

            return farthestReachSoFar >= endIndex;
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
