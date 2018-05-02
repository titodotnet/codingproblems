using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    /// <summary>
    /// Binary search tree traversal Breadth First Search.
    /// </summary>
    class BstTraversalBfs
    {
        public static void Main()
        {
            BstTraversalBfsProcessor processor = new BstTraversalBfsProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BstTraversalBfsProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            BreadthFirstSearch(this.root);
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

        private void BreadthFirstSearch(BstNode<int> node)
        {
            Queue<BstNode<int>> bstNodeStack = new Queue<BstNode<int>>();

            if (node != null)
            {
                bstNodeStack.Enqueue(node);
                Console.WriteLine("Breadth first search traversal......");
            }

            while (bstNodeStack.Count > 0)
            {
                var currentNode = bstNodeStack.Dequeue();

                Console.WriteLine($"{currentNode.Data}    ");

                if (currentNode.Left != null)
                {
                    bstNodeStack.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    bstNodeStack.Enqueue(currentNode.Right);
                }
            }
        }

    }
}
