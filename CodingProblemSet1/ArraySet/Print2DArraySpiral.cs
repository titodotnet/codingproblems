using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class Print2DArraySpiral
    {
        public static void Main()
        {
            Print2DArraySpiralProcessor processor = new Print2DArraySpiralProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class Print2DArraySpiralProcessor
    {
        int[][] matrix;

        public void Process()
        {
            Initialize();
            Console.WriteLine("Original matrix");
            PrintMatrix();
            Console.WriteLine("----------------");


            Console.WriteLine("Spiral print");
            Print2DArraySpiral(this.matrix);
        }

        private void Initialize()
        {
            //matrix = new int[][]{
            //    new int[] { 1, 2},
            //    new int[] { 3, 4}
            //};
            //this.count = 2;

            //matrix = new int[][]{
            //    new int[] { 1, 2, 3},
            //    new int[] { 4, 5, 6},
            //    new int[] { 7, 8, 9}
            //};
            //this.count = 3;

            matrix = new int[][]{
                new int[] { 1, 2, 3, 4},
                new int[] { 5, 6, 7, 8},
                new int[] { 9, 10, 11, 12},
                new int[] { 13, 14, 15, 16}
            };
            //this.count = 4;

            //matrix = new int[][]{
            //    new int[] { 1, 2, 3, 4, 5},
            //    new int[] { 6, 7, 8, 9, 10},
            //    new int[] { 11, 12, 13, 14, 15},
            //    new int[] { 16, 17, 18, 19, 20},
            //    new int[] { 21, 22, 23, 24, 25}
            //};
            //this.count = 5;
        }

        private void Print2DArraySpiral(int[][] matrix)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            // In our case both rowCount and colCount should be equal as this is expected to be NxN matrix.

            int row = 0;
            int col = 0;
            int rowMax = rowCount - 1;
            int colMax = colCount - 1;
            int direction = 0; // 0:left to right, 1:top to bottom, 2:right to left, 3:bottom to top

            while (row <= rowMax && col <= colMax)
            {
                if (direction == 0)
                {
                    for (int i = col; i <= colMax; i++)
                    {
                        Console.Write($"{matrix[row][i]}  ");
                    }
                    row++;
                }

                if (direction == 1)
                {
                    for (int i = row; i <= rowMax; i++)
                    {
                        Console.Write($"{matrix[i][colMax]}  ");
                    }
                    colMax--;
                }

                if (direction == 2)
                {
                    for (int i = colMax; i >= col; i--)
                    {
                        Console.Write($"{matrix[rowMax][i]}  ");
                    }
                    rowMax--;
                }

                if (direction == 3)
                {
                    for (int i = rowMax; i >= row; i--)
                    {
                        Console.Write($"{matrix[i][col]}  ");
                    }
                    col++;
                }

                direction = (direction + 1) % 4;
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
