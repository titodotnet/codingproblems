using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class SetEntireRowCol0
    {
        public static void Main()
        {
            SetEntireRowCol0Processor processor = new SetEntireRowCol0Processor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class SetEntireRowCol0Processor
    {
        int[][] matrix;
        int rowCount;
        int colCount;

        public void Process()
        {
            Initialize();
            Console.WriteLine("Original matrix");
            PrintMatrix();
            Console.WriteLine("----------------");

            SetToZero();
            Console.WriteLine("Updated matrix");
            PrintMatrix();
            Console.WriteLine("----------------");
        }

        private void Initialize()
        {
            matrix = new int[][]
            {
                new int[]{0, 1, 1, 0},
                new int[]{1, 1, 0, 1},
                new int[]{1, 1, 1, 1}
            };
            this.rowCount = this.matrix.Length;
            this.colCount = this.matrix[0].Length;
        }

        private void SetToZero()
        {
            bool[] rowZeros = new bool[this.rowCount];
            bool[] colZeros = new bool[this.colCount];

            for (int i = 0; i < this.rowCount; i++)
            {
                for (int j = 0; j < this.colCount; j++)
                {
                    if (this.matrix[i][j] == 0)
                    {
                        rowZeros[i] = true;
                        colZeros[j] = true;
                    }
                }
            }

            for (int i = 0; i < this.rowCount; i++)
            {
                for (int j = 0; j < this.colCount; j++)
                {
                    if (rowZeros[i] || colZeros[j])
                    {
                        this.matrix[i][j] = 0;
                    }
                }
            }
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
