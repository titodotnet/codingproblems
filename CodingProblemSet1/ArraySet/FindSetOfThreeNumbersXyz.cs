using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class FindSetOfThreeNumbersXyz
    {
        public static void Main()
        {
            FindSetOfThreeNumbersXyzProcessor processor = new FindSetOfThreeNumbersXyzProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class FindSetOfThreeNumbersXyzProcessor
    {
        public void Process()
        {
            char[] input = new char[] {'1','3','5','6',',','4','9','7','3',',','2','3',',','7','7',',','2','2',',','9','9',',','1' };
            Evaluate(input);
        }

        private void Evaluate(char[] inputArray)
        {
            List<int> numArray = new List<int>();
            string currentValue = string.Empty;

            foreach (var item in inputArray)
            {
                if (item == ',')
                {
                    numArray.Add(int.Parse(currentValue));
                    currentValue = string.Empty;
                }
                else
                {
                    currentValue += item;
                }
            }

            int? x = null;
            int? y = null;
            int? z = null;

            foreach (var item in numArray)
            {
                if (!x.HasValue)
                {
                    x = item;
                }
                else if (!y.HasValue)
                {
                    y = item;
                }
                else if (!z.HasValue)
                {
                    z = item;
                }
                else
                {
                    x = y;
                    y = z;
                    z = item;
                }

                if (x.HasValue && y.HasValue && z.HasValue)
                {
                    if (z == (x + y))
                    {
                        Console.WriteLine($"{x} + {y} = {z}");
                    }
                }
            }
        }
    }
}
