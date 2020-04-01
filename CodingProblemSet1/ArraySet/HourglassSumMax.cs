using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class HourglassSumMax
    {
        public static void Main()
        {
            HourglassSumMaxProcessor processor = new HourglassSumMaxProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    // Example 1
    // arr[i][j] =
    // [
    //   [ 1, 1, 1, 0, 0, 0 ],
    //   [ 0, 1, 0, 0, 0, 0 ],
    //   [ 1, 1, 1, 0, 0, 0 ],
    //   [ 0, 0, 2, 4, 4, 0 ],
    //   [ 0, 0, 0, 2, 0, 0 ],
    //   [ 0, 0, 1, 2, 4, 0 ]
    // ]// an hourglass might look like
    // 1 1 1
    //   1 
    // 1 1 1
    // or
    // arr[0][0], a[0][1], a[0][2]
    //            a[1][1]
    // arr[2][0], a[2][1], a[2][2]// The sum of this first hourglass is 7
    class HourglassSumMaxProcessor
    {
        int[][] matrix = new int[6][];
        public void Process()
        {
            Initialize();
            Console.WriteLine("Original matrix");
            PrintMatrix();
            Console.WriteLine("----------------");


            Console.WriteLine("Max Hourglass value");
            CalculateMaxHourglassValue(matrix);
        }

        private void Initialize()
        {
            matrix = new int[][]{
                new int[] { -9, -9, -9, 1, 1,1},
                new int[] { 0, -9, 0, 4, 3,2},
                new int[] { -9, -9, -9, 1, 2,3},
                new int[] { 0, 0, 8, 6, 6,0},
                new int[] { 0, 0, 0, -2, 0,0},
                new int[] { 0, 0, 1, 2, 4,0}
            };
            
        }

        private void CalculateMaxHourglassValue(int[][] matrix)
        {
            int? maxValue = null;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int currentValue = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] + matrix[i + 1][j + 1] + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                    if (maxValue.HasValue)
                    {
                        maxValue = Math.Max(currentValue, maxValue.Value);
                    }
                    else
                    {
                        maxValue = currentValue;
                    }
                }
            }

            Console.WriteLine($"{maxValue}");
        }

        private void PrintMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($" {matrix[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
