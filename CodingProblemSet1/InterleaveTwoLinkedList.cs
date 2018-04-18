using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1
{
    // Merge/Interleave two linked list.
    // Example:
    //  FirstList: 1->2->3      SecondList:  4->5->6->7->8
    // Expected result: 
    //  FirstList: 1->4->2->5->3->6      SecondList:  7->8
    class InterleaveTwoLinkedList
    {
        public static void Main()
        {
            MergeTwoLinkedList mergeTwoLinkedList = new MergeTwoLinkedList();
            mergeTwoLinkedList.Process();

            Console.ReadKey();
        }
    }

    class MergeTwoLinkedList
    {        
        public void Process()
        {
            PrepareData();
        }

        private void PrepareData()
        {
            Node firstList = new Node(1);
            firstList.Next = new Node(2);
            firstList.Next.Next = new Node(3);

            Node secondList = new Node(4);
            secondList.Next = new Node(5);
            secondList.Next.Next = new Node(6);
            secondList.Next.Next.Next = new Node(7);
            secondList.Next.Next.Next.Next = new Node(8);

            Console.WriteLine("Original list - FirstList:");
            PrintList(firstList);

            Console.WriteLine("Original list - SecondList:");
            PrintList(secondList);

            AlternateMerge(firstList, secondList);
        }

        private void AlternateMerge(Node first, Node second)
        {
            Node firstTemp = first;

            while (first != null && second != null)
            {
                Node firstNext = first.Next;
                Node secondNext = second.Next;

                first.Next = second;
                second.Next = firstNext;

                first = firstNext;
                second = secondNext;
            }

            Console.WriteLine("Altered list - FirstList:");
            PrintList(firstTemp);

            Console.WriteLine("Altered list - SecondList:");
            PrintList(second);
        }

        private void PrintList(Node head)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }

    class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
