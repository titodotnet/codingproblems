using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class CompressRepeatedCharString
    {
        public static void Main()
        {
            CompressString();
            Console.ReadKey();
        }

        private static void CompressString()
        {
            string textToBeCompressed = "rrepppppeeeeeaateeeeeeedddd";
            int counter = 1;
            char lastChar = textToBeCompressed[0];

            string result = "";

            for (int i = 1; i <= textToBeCompressed.Length - 1; i++)
            {
                if (textToBeCompressed[i] == lastChar)
                {
                    ++counter;
                }
                else
                {
                    result += lastChar.ToString() + counter.ToString();
                    counter = 1;
                    lastChar = textToBeCompressed[i];
                }
            }

            result += lastChar.ToString() + counter.ToString();
            Console.WriteLine($"original text {textToBeCompressed} has been compressed to {result}");
        }
    }
}
