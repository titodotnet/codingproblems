namespace CodingProblemSet1.ArraySet
{
    using System;

    class SortArrayByParity
    {
        public static void Main()
        {
            SortArrayByParityProcessor processor = new SortArrayByParityProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    // Given and array of non-negative integers, return an array of all even elements followed by odd elements.
    // Input = [3,1,2,4] , Output = [2,4,3,1]
    class SortArrayByParityProcessor
    {
        public void Process()
        {
            int[] array = { 3, 1, 2, 4 };

            int i = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] % 2 == 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
