using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class PrintLinkedListInReverse
    {
        public static void Main()
        {
            ReversePrintLinkedListProcessor processor = new ReversePrintLinkedListProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class ReversePrintLinkedListProcessor
    {
        private Node head;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);
            Node headNodeTobeReversed = this.head;

            Console.WriteLine("Linked list printed in reverse order");
            Reverse(headNodeTobeReversed);
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

        private void Reverse(Node head)
        {
            if (head == null)
            {
                return;
            }

            Reverse(head.Next);

            Console.Write($"{head.Data}  ");
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
