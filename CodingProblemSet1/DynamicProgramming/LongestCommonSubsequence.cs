using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.DynamicProgramming
{
    class LongestCommonSubsequence
    {
        public static void Main()
        {
            LongestCommonSubsequenceProcessor processor = new LongestCommonSubsequenceProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    // Given two sequences, find the length of longest subsequence present in both of them.
    // A subsequence is a sequence that appears in the same relative order, but not necessarily contiguous.
    // LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4.

    class LongestCommonSubsequenceProcessor
    {
        public void Process()
        {
            LongestCommonSubsequence("AGGTAB", "GXTXAYB");
            LongestCommonSubsequence("ABCDGH", "AEDFHR");
        }

        private void LongestCommonSubsequence(string str1, string str2)
        {
            int[][] table = new int[str1.Length + 1][];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new int[str2.Length + 1];
            }

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[0].Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        table[i][j] = 0;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        table[i][j] = table[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        table[i][j] = Math.Max(table[i][j - 1], table[i - 1][j]);
                    }
                }
            }

            int resultLength = table[str1.Length][str2.Length];

            PrintLongestCommonSubsequence(table, str1, str2,resultLength);

            Console.WriteLine($"Length of Longest common subsequence of {str1} and {str2} is {resultLength}");
        }

        private void PrintLongestCommonSubsequence(int[][] table, string str1, string str2, int resultLength)
        {
            int i = table.Length - 1;
            int j = table[0].Length - 1;
            char[] result = new char[resultLength];
            int index = resultLength - 1;

            while (i != 0 && j != 0)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    result[index] = str1[i - 1];
                    index--;
                    i--;
                    j--;
                }
                else
                {
                    if (table[i - 1][j] > table[i][j - 1])
                    {
                        i--;
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            string resultant = new string(result);
            Console.WriteLine($"Longest common subsequence of {str1} and {str2} is {resultant}");
        }
    }
}
