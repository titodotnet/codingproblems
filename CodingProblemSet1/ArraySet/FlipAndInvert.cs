namespace CodingProblemSet1.ArraySet
{
    using System;
    class FlipAndInvert
    {
        public static void Main()
        {

            FlipAndInvertProcessor processor = new FlipAndInvertProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    // Binary matrix. Flip [1,1,0] is [0,1,1]. Invert [0,1,1] is [1,0,0]

    class FlipAndInvertProcessor
    {
        int[][] matrix = { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };

        public void Process()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int low = 0;
                int high = matrix[i].Length - 1;

                while (low <= high)
                {
                    if (matrix[i][low] == matrix[i][high]) // Since this is binary matrix, if the values of low and high are different, flipping and inverting will result in same value.
                    {
                        matrix[i][low] = 1 - matrix[i][high];
                        matrix[i][high] = matrix[i][low];
                    }
                    low++;
                    high--;
                }
            }
            PrintMatrix();
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
