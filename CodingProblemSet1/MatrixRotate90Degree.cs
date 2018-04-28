using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class MatrixRotate90Degree
    {
        public static void Main()
        {
            MatrixRotation90DegreeProcessor processor = new MatrixRotation90DegreeProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class MatrixRotation90DegreeProcessor
    {
        int[][] matrix;
        int count;
        public void Process()
        {
            Initialize();
            Console.WriteLine("Original matrix");
            PrintMatrix();
            Console.WriteLine("----------------");

            //RotateBy90Degree1();
            RotateBy90DegreeUsingForLoop();
            Console.WriteLine("Rotated matrix");
            PrintMatrix();
            Console.WriteLine("----------------");
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
            this.count = 4;

            //matrix = new int[][]{
            //    new int[] { 1, 2, 3, 4, 5},
            //    new int[] { 6, 7, 8, 9, 10},
            //    new int[] { 11, 12, 13, 14, 15},
            //    new int[] { 16, 17, 18, 19, 20},
            //    new int[] { 21, 22, 23, 24, 25}
            //};
            //this.count = 5;
        }

        private void RotateBy90Degree()
        {
            int row = 0;
            int col = 0;
            int rowMax = this.count - 1;
            int colMax = this.count - 1;

            while (row < rowMax & col < colMax)
            {
                int counter = 0;
                for (int i = col; i < colMax; i++)
                {
                    var temp = matrix[row][i];
                    matrix[row][i] = matrix[rowMax - counter][col];

                    var tempNext = matrix[i][colMax];
                    matrix[i][colMax] = temp;
                    temp = tempNext;

                    tempNext = matrix[rowMax][colMax - counter];
                    matrix[rowMax][colMax - counter] = temp;
                    temp = tempNext;

                    matrix[rowMax - counter][col] = temp;

                    counter++;
                }

                row++;
                rowMax--;
                col++;
                colMax--;
            }
        }

        /// <summary>
        /// Rotate matrix by 90 degree clockwise.
        /// </summary>
        /// <remarks>
        /// Easy to understand. 
        /// Maintin 4 different points (row, rowmax, col, colmax) which can be used to determine 4 corners of the matrix.
        /// Inner loop (For) rotates the value of the matrix border. Each pass will rotate one element from each side.
        /// Outer loop (While) changes the value of 4 points (row, rowmax, col, colmax) to reduce the border of the matrix one level inner.
        /// </remarks>
        private void RotateBy90Degree1()
        {
            int row = 0;
            int col = 0;
            int rowMax = this.count - 1;
            int colMax = this.count - 1;

            while (row < rowMax & col < colMax)
            {
                int counter = 0;
                for (int i = col; i < colMax; i++)
                {
                    var temp = matrix[row][i];

                    matrix[row][i] = matrix[rowMax - counter][col];
                    matrix[rowMax - counter][col] = matrix[rowMax][colMax - counter];
                    matrix[rowMax][colMax - counter] = matrix[i][colMax];
                    matrix[i][colMax] = temp;

                    counter++;
                }

                row++;
                rowMax--;
                col++;
                colMax--;
            }
        }

        private void RotateBy90DegreeUsingForLoop()
        {
            int n = this.count;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    var temp = matrix[i][j];

                    matrix[i][j] = matrix[n - 1 - j][i];
                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                    matrix[j][n - 1 - i] = temp;
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
