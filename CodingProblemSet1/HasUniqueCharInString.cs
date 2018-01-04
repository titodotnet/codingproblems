using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class HasUniqueCharInString
    {
        // 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters.  What if you cannot use additional data structures?

        static void Main()
        {
            IdentifyHavingUniueChar();
            Console.ReadKey();
        }

        private static void IdentifyHavingUniueChar()
        {
            string[] sampleStrings = { "isunique", "unique", "umbrela", "umbrella" };

            foreach (var item in sampleStrings)
            {
                Console.WriteLine($"Is word {item} is unique: {IsUnique(item)}");
            }
        }

        private static bool IsUnique(string word)
        {
            if (word.Length > 256)
            {
                return false;
            }

            HashSet<char> hashSet = new HashSet<char>();

            foreach (var item in word)
            {
                if (hashSet.Contains(item))
                {
                    return false;
                }

                hashSet.Add(item);
            }

            return true;
        }
    }
}
