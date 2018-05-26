using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.DynamicProgramming
{
    class EditDistanceProblem
    {
        public static void Main()
        {
            EditDistanceProblemProcessor processor = new EditDistanceProblemProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class EditDistanceProblemProcessor
    {
        public void Process()
        {
            EvaluateEditDistance("sunday","saturday");
        }

        private int EvaluateEditDistance(string str1, string str2)
        {
            int[,] table = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (i == 0)
                    {
                        table[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        table[i, j] = i;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        table[i, j] = table[i - 1, j - 1];
                    }
                    else
                    {
                        table[i, j] = 1 + Math.Min(table[i, j - 1], Math.Min(table[i - 1, j], table[i - 1, j - 1]));
                    }
                }
            }

            PrintEdit(table, str1, str2);
            return table[str1.Length, str2.Length];
        }

        private void PrintEdit(int[,] table, string str1, string str2)
        {
            int i = str1.Length;
            int j = str2.Length;

            while (i != 0 && j != 0)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    i = i - 1;
                    j = j - 1;
                }
                else if (table[i, j] == 1 + table[i - 1, j - 1])
                {
                    Console.WriteLine($"{str1[i - 1]} has been replaced with {str2[j - 1]}");
                    i--;
                    j--;
                }
                else if (table[i, j] == 1 + table[i - 1, j])
                {
                    Console.WriteLine($"{str1[i - 1]} has been deleted");
                    i--;
                }
                else if (table[i, j] == 1 + table[i, j - 1])
                {
                    Console.WriteLine($"{str2[j - 1]} has been inserted after {str1[i - 1]}");
                    j--;
                }
            }
        }
    }
}
