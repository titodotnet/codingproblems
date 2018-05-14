using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class Sort012DutchFlagProblem
    {
        public static void Main()
        {
            Sort012DuctchFlagProblemProcessor processor = new Sort012DuctchFlagProblemProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class Sort012DuctchFlagProblemProcessor
    {
        int[] array;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Priniting the original array");
            Print(this.array);

            Console.WriteLine("Priniting the sorted array");
            Print(Sort012DutchFlagModel(this.array));
        }

        private void Initialize()
        {
            this.array = new int[] { 0, 1, 2, 0, 1, 2 };
        }

        private int[] Sort012DutchFlagModel(int[] array)
        {
            int low = 0;
            int mid = 0;
            int high = array.Length - 1;
            int temp = 0;

            while (mid <= high)
            {
                switch (array[mid])
                {
                    case 0:
                        temp = array[low];
                        array[low] = array[mid];
                        array[mid] = temp;
                        mid++;
                        low++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = array[mid];
                        array[mid] = array[high];
                        array[high] = temp;
                        high--;
                        break;
                    default:
                        break;
                }
            }
            return array;
        }

        private void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }

            Console.WriteLine();
        }

    }
}
