using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class PartitionLinkedListAroundAValue
    {
        public static void Main()
        {
            PartitionLinkedListProcessor processor = new PartitionLinkedListProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class PartitionLinkedListProcessor
    {
        private Node head;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);

            Partition(7);
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
        }

        private void Partition(int value)
        {
            Node beforeStart = null;
            Node beforeEnd = null;
            Node afterStart = null;
            Node afterEnd = null;

            Node currentNode = this.head;
            Node next = null;
            while (currentNode != null)
            {
                next = currentNode.Next;
                currentNode.Next = null;

                if (currentNode.Data < value)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = currentNode;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.Next = currentNode;
                        beforeEnd = beforeEnd.Next;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = currentNode;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.Next = currentNode;
                        afterEnd = afterEnd.Next;
                    }
                }
                currentNode = next;
            }

            if (beforeStart == null)
            {
                Console.WriteLine("Partitioned Linked list");
                PrintLinkedList(afterStart);
                return;
            }

            beforeEnd.Next = afterStart;

            Console.WriteLine("Partitioned Linked list");
            PrintLinkedList(beforeStart);
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
