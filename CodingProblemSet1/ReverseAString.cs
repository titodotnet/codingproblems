using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class ReverseAString
    {
        public static void Main()
        {
            ReverseString();
            ReverseString1();
            Console.ReadKey();
        }

        private static void ReverseString()
        {
            string toBeReveresed = "reversethis";

            char[] reversedChars = toBeReveresed.ToCharArray();
            for (int i = 0, j = toBeReveresed.Length-1; i < j; i++,j--)
            {
                var temp = reversedChars[i];
                reversedChars[i] = reversedChars[j];
                reversedChars[j] = temp;
            }

            Console.WriteLine($"Reversed string of {toBeReveresed} is {new String(reversedChars)}");
        }

        private static void ReverseString1()
        {
            string toBeReveresed = "reversethis";

            char[] reversedChars = new char[toBeReveresed.Length];
            for (int i = 0, j = toBeReveresed.Length - 1; i <= j; i++, j--)
            {                
                // When i and j are equal either of the below statement execution is enough.
                reversedChars[i] = toBeReveresed[j];
                reversedChars[j] = toBeReveresed[i];
            }

            Console.WriteLine($"Using new char[]: Reversed string of {toBeReveresed} is {new String(reversedChars)}");
        }
    }
}
