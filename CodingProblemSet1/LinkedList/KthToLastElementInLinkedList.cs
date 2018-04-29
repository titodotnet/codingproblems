using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class KthToLastElementInLinkedList
    {
        public static void Main()
        {
            KthToLastElementProcessor processor = new KthToLastElementProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class KthToLastElementProcessor
    {
        private Node head;
        public void Process()
        {
            Initialize();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);

            FindElement(4);
        }

        private void Initialize()
        {
            this.head = new Node { Data = 5 };
            this.head.Next = new Node { Data = 2 };
            this.head.Next.Next = new Node { Data = 7 };
            this.head.Next.Next.Next = new Node { Data = 1 };
            this.head.Next.Next.Next.Next = new Node { Data = 2 };
            this.head.Next.Next.Next.Next.Next = new Node { Data = 11 };
            this.head.Next.Next.Next.Next.Next.Next = new Node { Data = 10 };
            this.head.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 9 };
            this.head.Next.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 15 };
        }

        private void FindElement(int position)
        {
            int counter = 0;

            Node forwardPointer = this.head;
            Node backwardPointer = null;

            while (forwardPointer != null)
            {
                counter++;
                if (counter == position)
                {
                    backwardPointer = this.head;
                }

                forwardPointer = forwardPointer.Next;
                if (forwardPointer != null && backwardPointer != null)
                {
                    backwardPointer = backwardPointer.Next;
                }

            }

            if (backwardPointer != null)
            {
                Console.WriteLine($"Position {position} from the last in the lined list is {backwardPointer.Data}");
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }

        private void FindElement1(int position)
        {
            Node forwardPointer = this.head;
            Node backwardPointer = null;

            for (int i = 0; i < position; i++)
            {
                if (forwardPointer == null)
                {
                    break;
                }

                forwardPointer = forwardPointer.Next;
            }

            if (forwardPointer != null)
            {
                backwardPointer = this.head;
            }

            while (forwardPointer != null)
            {
                forwardPointer = forwardPointer.Next;
                backwardPointer = backwardPointer.Next;
            }

            if (backwardPointer != null)
            {
                Console.WriteLine($"Position {position} from the last in the lined list is {backwardPointer.Data}");
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }

        private void PrintLinkedList(Node head)
        {
            while (head != null)
            {
                string connector = (head.Next != null) ? "== > " : string.Empty;
                Console.Write($" {head.Data} {connector} ");

                head = head.Next;
            }
            Console.WriteLine();
        }
    }
}
