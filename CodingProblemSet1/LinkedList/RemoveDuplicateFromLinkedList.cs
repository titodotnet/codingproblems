using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class RemoveDuplicateFromLinkedList
    {
        public static void Main()
        {
            RemoveDuplicateProcessor processor = new RemoveDuplicateProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class RemoveDuplicateProcessor
    {
        private Node head;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);

            RemoveDuplicate();

            Console.WriteLine("Updated Linked list");
            PrintLinkedList(this.head);
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

        private void RemoveDuplicate()
        {
            HashSet<int> visitedData = new HashSet<int>();
            //Node headNode = this.head;
            Node currentNode = this.head;
            Node previousNode = null;
            while (currentNode != null)
            {
                if (visitedData.Contains(currentNode.Data))
                {
                    previousNode.Next = currentNode.Next;
                }
                else
                {
                    visitedData.Add(currentNode.Data);
                    previousNode = currentNode;
                }
                currentNode = currentNode.Next;
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

    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
