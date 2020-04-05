using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class LeftRotation
    {
        public static void Main()
        {
            LeftRotateProcessor processor = new LeftRotateProcessor();
            processor.Process1();

            Console.ReadKey();
        }
    }

    // A left rotation operation on an array of size n shifts each of the array's elements 1 unit to the left.
    // For example, if 2 left rotations are performed on array [1,2,3,4,5] , then the array would become [3,4,5,1,2].

    class LeftRotateProcessor
    {
        // Using another array for output
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
                rotatedArray[i] = arrayToRotate[shiftIndex];
            }
            Console.WriteLine(string.Join(" ", rotatedArray));
        }

        // Using same array - need to perform 1 shift at a time

        public void Process1()
        {
            int[] arrayToRotate = { 1, 2, 3, 4, 5 };
            int count = arrayToRotate.Length;
            int rotationCount = 2;

            for (int i = 0; i < rotationCount; i++)
            {
                int first = arrayToRotate[0];
                for (int j = 0; j < count; j++)
                {
                    if ((j+1) == count)
                    {
                        arrayToRotate[j] = first;
                    }
                    else
                    {
                        arrayToRotate[j] = arrayToRotate[j + 1];
                    }                    
                }
            }

            Console.WriteLine(string.Join(" ", arrayToRotate));
        }
    }
}
