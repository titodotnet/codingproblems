using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class MoveZerosToEnd
    {
        static void Main(string[] args)
        {
            int[] sourceArray = new[] { 5, 0, 7, 0, 11, 17, 0, 0, 25, 45 };
            MoveZeros(sourceArray);

            foreach (int item in sourceArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void MoveZeros(int[] source)
        {
            int index = 0;

            int endRange = source.Length;

            while (index < endRange)
            {
                if (source[index] == 0)
                {
                    MoveToEnd(source, index, endRange);
                    endRange--;
                    //index--;
                }
                else
                {
                    index++;
                }
            }

            // Below implementation won't work for consecutive zeros
            ////for (int i = 0; i < source.Length; i++)
            ////{
            ////    if (source[i] == 0)
            ////    {
            ////        MoveToEnd(source, i);
            ////    }
            ////}
        }

        private static void MoveToEnd(int[] source, int index, int endRange)
        {
            for (int i = index; i < endRange - 1; i++)
            {
                int temp = source[i];
                source[i] = source[i + 1];
                source[i + 1] = temp;
            }
        }

        private static void MoveToEnd(int[] source, int index)
        {
            for (int i = index; i < source.Length - 1; i++)
            {
                int temp = source[i];
                source[i] = source[i + 1];
                source[i + 1] = temp;
            }
        }
    }
}
