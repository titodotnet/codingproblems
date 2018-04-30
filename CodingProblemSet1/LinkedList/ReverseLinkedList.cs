using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class ReverseLinkedList
    {
        public static void Main()
        {
            ReverseLinkedListProcessor processor = new ReverseLinkedListProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class ReverseLinkedListProcessor
    {
        private Node head;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);

            Reverse();
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

        private void Reverse()
        {
            Node current = this.head;
            Node previous = null;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            this.head = previous;

            Console.WriteLine("Reversed liked list");
            PrintLinkedList(this.head);
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
