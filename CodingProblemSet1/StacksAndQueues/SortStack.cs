using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    /// <summary>
    /// Sorts the stack.
    /// </summary>
    /// <remarks>
    /// Sort the stack using one more stack.
    /// </remarks>
    class SortStack
    {
        public static void Main()
        {
            SortStackProcessor processor = new SortStackProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class SortStackProcessor
    {
        Stack<int> unorderedData = new Stack<int>();

        public void Process()
        {
            Initialize();
            Sort();
        }

        private void Initialize()
        {
            unorderedData.Push(25);
            unorderedData.Push(29);
            unorderedData.Push(5);
            unorderedData.Push(2);
            unorderedData.Push(15);
            unorderedData.Push(21);
            unorderedData.Push(45);
            unorderedData.Push(9);
            unorderedData.Push(7);
            unorderedData.Push(42);
        }

        private void Sort()
        {
            Stack<int> orderedData = new Stack<int>();

            while (unorderedData.Count > 0)
            {
                int current = unorderedData.Pop();

                while (orderedData.Count > 0 && orderedData.Peek() < current)
                {
                    unorderedData.Push(orderedData.Pop());
                }
                orderedData.Push(current);
            }
            Print(orderedData);
        }

        private void Print(Stack<int> stackData)
        {
            while (stackData.Count > 0)
            {
                Console.Write($"    {stackData.Pop()}");
            }
        }
    }
}
