using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Arrays
{
    class _1DArrayMultiplication
    {
        public static void Main()
        {
            _1DArrayMultiplicationProcessor processor = new _1DArrayMultiplicationProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class _1DArrayMultiplicationProcessor
    {
        public void Process()
        {
            //int[] a = { 1, 2, 3 };
            //int[] b = { 4, 5, 6 };
            int[] a = { 9, 9, 9 };
            int[] b = { 9, 9, 9 };

            Multiply(a, b);
        }

        private void Multiply(int[] array1, int[] array2)
        {
            int n = array1.Length;
            int m = array2.Length;
            int[] result = new int[n + m];

            for (int i = n-1; i >= 0; i--)
            {
                for (int j = m-1; j >= 0; j--)
                {
                    int temp = array1[i] * array2[j];

                    result[i + j + 1] += temp;
                    result[i + j] += result[i + j + 1] / 10;
                    result[i + j + 1] = result[i + j + 1] % 10;
                    
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]}");
            }
        }
    }
}
