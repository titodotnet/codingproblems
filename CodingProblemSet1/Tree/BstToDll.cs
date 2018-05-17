using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    /// <summary>
    /// Convert Binary Search Tree (BST) to Sorted Doubly-Linked List.
    /// </summary>
    /// <remarks>
    /// Ref: https://articles.leetcode.com/convert-binary-search-tree-bst-to/
    /// </remarks>
    class BstToDll
    {
        public static void Main()
        {
            BstToDllProcessor processor = new BstToDllProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BstToDllProcessor
    {
        BstNode<int> root;
        BstNode<int> head;
        BstNode<int> previous;

        public void Process()
        {
            Initialize();
            ConvertBstToDll(this.root);

            // Now head will have the circular Doubly Linked list.
        }


        private void Initialize()
        {
            this.root = new BstNode<int> { Data = 20 };
            this.root.Left = new BstNode<int> { Data = 10 };
            this.root.Right = new BstNode<int> { Data = 30 };

            this.root.Left.Left = new BstNode<int> { Data = 5 };
            this.root.Left.Right = new BstNode<int> { Data = 15 };

            this.root.Right.Left = new BstNode<int> { Data = 25 };
            this.root.Right.Right = new BstNode<int> { Data = 35 };

            this.root.Right.Left.Right = new BstNode<int> { Data = 27 };
            this.root.Right.Left.Right.Right = new BstNode<int> { Data = 28 };
        }

        private void ConvertBstToDll(BstNode<int> current)
        {
            if (current == null)
            {
                return;
            }

            ConvertBstToDll(current.Left);

            if (previous == null)
            {
                head = current;
            }
            else
            {
                previous.Right = current;
                current.Left = previous;
            }

            // Below three lines are to make the Doubly Linked List Circular.
            var right = current.Right;
            head.Left = current;
            current.Right = head;

            previous = current;

            ConvertBstToDll(right);
        }
    }
}
