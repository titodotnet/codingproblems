using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class IdentifyLoopStartOfLinkedList
    {
        public static void Main()
        {
            FindLoopStartProcessor processor = new FindLoopStartProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class FindLoopStartProcessor
    {
        private Node head;

        public void Process()
        {
            Initialize();

            FindLoopStart();
        }
        
        private void Initialize()
        {
            this.head = new Node { Data = 15 };
            this.head.Next = new Node { Data = 2 };
            this.head.Next.Next = new Node { Data = 7 };
            this.head.Next.Next.Next = new Node { Data = 1 };
            this.head.Next.Next.Next.Next = new Node { Data = 2 };
            this.head.Next.Next.Next.Next.Next = new Node { Data = 11 };
            this.head.Next.Next.Next.Next.Next.Next = new Node { Data = 10 };
            this.head.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 9 };
            this.head.Next.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 5 };
            // Seeting the loop
            this.head.Next.Next.Next.Next.Next.Next.Next.Next.Next = this.head.Next.Next.Next.Next;
            //this.head.Next.Next.Next.Next.Next.Next.Next.Next.Next = this.head;
        }

        private void FindLoopStart()
        {
            Node forwardPointer = this.head;
            Node backwardPointer = this.head;

            while (forwardPointer != null && forwardPointer.Next != null)
            {
                forwardPointer = forwardPointer.Next.Next;
                backwardPointer = backwardPointer.Next;

                if (forwardPointer == backwardPointer)
                {
                    break;
                }
            }

            // Identify if there is a loop
            if (forwardPointer == null || forwardPointer.Next==null)
            {
                // No loop.
                Console.WriteLine("No loop");
                return;
            }

            backwardPointer = this.head;

            while (forwardPointer != backwardPointer)
            {
                forwardPointer = forwardPointer.Next;
                backwardPointer = backwardPointer.Next;
            }

            Console.WriteLine($"Starting of the loop is {forwardPointer.Data}");
        }
    }
}
