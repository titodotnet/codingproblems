using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.LinkedList
{
    class PalindromeLinkedList
    {
        public static void Main()
        {
            PalindromeLinkedListProcessor processor = new PalindromeLinkedListProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class PalindromeLinkedListProcessor
    {
        private Node head;

        public void Process()
        {
            InitializePalindrome();
            //InitializeNotPalindrome();

            Console.WriteLine("Original Linked list");
            PrintLinkedList(this.head);

            Console.WriteLine($"Is the linked list palindrome : {IsPalindrome()}");
        }


        private void InitializePalindrome()
        {
            this.head = new Node { Data = 15 };
            this.head.Next = new Node { Data = 2 };
            this.head.Next.Next = new Node { Data = 7 };
            this.head.Next.Next.Next = new Node { Data = 1 };
            this.head.Next.Next.Next.Next = new Node { Data = 2 };
            this.head.Next.Next.Next.Next.Next = new Node { Data = 1 };
            this.head.Next.Next.Next.Next.Next.Next = new Node { Data = 7 };
            this.head.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 2 };
            this.head.Next.Next.Next.Next.Next.Next.Next.Next = new Node { Data = 15 };
        }

        private void InitializeNotPalindrome()
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

        private bool IsPalindrome()
        {
            Node forwardPointer = this.head;
            Node backwardPointer = this.head;
            Stack<int> firstHalfStack = new Stack<int>();

            while (forwardPointer != null && forwardPointer.Next != null)
            {
                firstHalfStack.Push(backwardPointer.Data);
                forwardPointer = forwardPointer.Next.Next;
                backwardPointer = backwardPointer.Next;
            }

            if (forwardPointer != null)
            {
                backwardPointer = backwardPointer.Next;
            }

            while (backwardPointer != null)
            {
                var topValueFromStack = firstHalfStack.Pop();
                if (backwardPointer.Data != topValueFromStack)
                {
                    return false;
                }

                backwardPointer = backwardPointer.Next;
            }

            return true;
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
