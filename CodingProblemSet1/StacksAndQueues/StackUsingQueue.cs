using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    class StackUsingQueue
    {
        public static void Main()
        {
            StackUsingQueue1Processor processor = new StackUsingQueue1Processor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class StackUsingQueue1Processor
    {
        public void Process()
        {
            StackUsingQueuePushCostly stackUsingQueue = new StackUsingQueuePushCostly();

            for (int i = 0; i < 5; i++)
            {
                stackUsingQueue.Push(i);
            }

            while (stackUsingQueue.Count > 0)
            {
                Console.WriteLine($"{stackUsingQueue.Pop()}");
            }
        }
    }

    class StackUsingQueuePushCostly
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        
        public int Count { get; private set; }

        public StackUsingQueuePushCostly()
        {
            Count = 0;
        }

        public void Push(int item)
        {
            q2.Enqueue(item);
            
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            Count++;

            var temp = q1;
            q1 = q2;
            q2 = temp;
        }

        public int Pop()
        {
            if (this.Count < 1)
            {
                throw new Exception("Pop cannot be performed on empty structure");
            }

            Count--;
            return q1.Dequeue();
        }
    }
}
