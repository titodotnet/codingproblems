using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class ArePermutationStrings
    {
        public static void Main()
        {
            AreStringsPermutations();
            Console.ReadKey();
        }

        private static void AreStringsPermutations()
        {
            string string1 = "testforpermutation";
            string string2 = "forpermutationtest";

            if (string1.Length != string2.Length)
            {
                Console.WriteLine($"{string1} and {string2} are not permutations");
                return;
            }

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (char item in string1)
            {
                if (charCounter.ContainsKey(item))
                {
                    charCounter[item]++;
                }
                else
                {
                    charCounter[item] = 1;
                }
            }

            foreach (char item in string2)
            {
                if (!charCounter.ContainsKey(item))
                {
                    Console.WriteLine($"{string1} and {string2} are not permutations");
                    return;
                }

                if (charCounter[item]==1)
                {
                    charCounter.Remove(item);
                }
                else
                {
                    charCounter[item]--;
                }
            }
            Console.WriteLine($"{string1} and {string2} are permutations");
        }
    }
}
