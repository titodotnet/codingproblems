using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    class Palindrome
    {
        public static void Main()
        {
            CheckForPlaindrome();

            Console.ReadKey();
        }

        private static void CheckForPlaindrome()
        {
            string testPalindrome1 = "malayalam";
            string testPalindrome2 = "somevalue";

            Console.WriteLine($"Is {testPalindrome1} Palindrome? {IsPalindrome(testPalindrome1)}");
            Console.WriteLine($"Is {testPalindrome2} Palindrome? {IsPalindrome(testPalindrome2)}");
        }

        private static bool IsPalindrome(string stringToCheck)
        {
            int i = 0;
            int j = stringToCheck.Length - 1;

            while (i < j)
            {
                if (stringToCheck[i] != stringToCheck[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
