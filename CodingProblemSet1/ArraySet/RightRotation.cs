using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class RightRotation
    {
        public static void Main()
        {
            RightRotateProcessor processor = new RightRotateProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class RightRotateProcessor
    {
        public void Process()
        {
            int[] arrayToRotate = { 1, 2, 3, 4, 5 };
            int count = arrayToRotate.Length;
            int rotationCount = 2;
            int[] rotatedArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                int shiftIndex = i + rotationCount;

                if (shiftIndex >= count)
                {
                    shiftIndex = shiftIndex % count;
                }
                rotatedArray[shiftIndex] = arrayToRotate[i];
            }
            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
