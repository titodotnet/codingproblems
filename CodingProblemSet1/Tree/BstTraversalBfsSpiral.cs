using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    /// <summary>
    /// Print a BST in Zig zag irder or spiral order.
    /// </summary>
    /// <remarks>
    /// For input:
    ///         1
    ///     2        3
    /// 4        5 6        7 
    /// 
    /// Output would be:
    /// 1
    /// 3 2
    /// 4 5 6 7 
    /// </remarks>
    class BstTraversalBfsSpiral
    {
        public static void Main()
        {
            BstTraversalBfsSpiralProcessor processor = new BstTraversalBfsSpiralProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BstTraversalBfsSpiralProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();

            Console.WriteLine("Spiral printing of Binary tree");
            SpiralPrinting(this.root);
        }

        private void Initialize()
        {
            this.root = new BstNode<int> { Data = 1 };
            this.root.Left = new BstNode<int> { Data = 2 };
            this.root.Right = new BstNode<int> { Data = 3 };

            this.root.Left.Left = new BstNode<int> { Data = 4 };
            this.root.Left.Right = new BstNode<int> { Data = 5 };

            this.root.Right.Left = new BstNode<int> { Data = 6 };
            this.root.Right.Right = new BstNode<int> { Data = 7 };

            this.root.Left.Left.Left = new BstNode<int> { Data = 8 };
            this.root.Left.Right.Left = new BstNode<int> { Data = 9 };
            this.root.Right.Right.Right = new BstNode<int> { Data = 10 };
        }

        private void SpiralPrinting(BstNode<int> node)
        {
            if (node == null)
            {
                return;
            }

            Stack<BstNode<int>> leftToRightStack = new Stack<BstNode<int>>();
            Stack<BstNode<int>> rightToLeftStack = new Stack<BstNode<int>>();

            leftToRightStack.Push(node);

            while (leftToRightStack.Count > 0 || rightToLeftStack.Count > 0)
            {
                Console.WriteLine();

                while (leftToRightStack.Count > 0)
                {

                    var current = leftToRightStack.Pop();

                    Console.Write($"{current.Data}   ");

                    if (current.Left != null)
                    {
                        rightToLeftStack.Push(current.Left);
                    }

                    if (current.Right != null)
                    {
                        rightToLeftStack.Push(current.Right);
                    }
                }

                Console.WriteLine();

                while (rightToLeftStack.Count > 0)
                {

                    var current = rightToLeftStack.Pop();

                    Console.Write($"{current.Data}   ");

                    if (current.Right != null)
                    {
                        leftToRightStack.Push(current.Right);
                    }

                    if (current.Left != null)
                    {
                        leftToRightStack.Push(current.Left);
                    }
                }
            }
        }
    }
}
