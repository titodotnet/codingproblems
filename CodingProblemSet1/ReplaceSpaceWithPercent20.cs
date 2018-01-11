using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class ReplaceSpaceWithPercent20
    {
        public static void Main()
        {
            ReplaceSpace();
            Console.ReadKey();
        }

        private static void ReplaceSpace()
        {
            string textToBeReplaced = "string with space to be replace with percent 20";
            int spaceCounter = 0;
            foreach (char item in textToBeReplaced)
            {
                if (item == ' ')
                {
                    spaceCounter++;
                }
            }

            int totalNewLength = textToBeReplaced.Length + (spaceCounter * 2);
            char[] result = new char[totalNewLength];
            for (int i = textToBeReplaced.Length - 1; i >= 0; i--)
            {
                if (textToBeReplaced[i] == ' ')
                {
                    result[--totalNewLength] = '0';
                    result[--totalNewLength] = '2';
                    result[--totalNewLength] = '%';
                }
                else
                {
                    result[--totalNewLength] = textToBeReplaced[i];
                }
            }

            Console.WriteLine($"original text: {textToBeReplaced} ");
            Console.WriteLine($"replaced text: {new string(result)}");
        }
    }
}
