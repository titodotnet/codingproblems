using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class LowestCommonAncestorBst
    {
        public static void Main()
        {
            LowestCommonAncestorBstProcessor processor = new LowestCommonAncestorBstProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class LowestCommonAncestorBstProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            int value1 = 25;
            int value2 = 28;
            
            Console.WriteLine($"LowestCommonAncestor Iterative of {value1} and {value2} is: {LowestCommonAncestorIterative(this.root, value1, value2).Data}");
            Console.WriteLine($"LowestCommonAncestor Recursive of {value1} and {value2} is: {LowestCommonAncestorRecursive(this.root, value1, value2).Data}");
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
        private BstNode<int> LowestCommonAncestorIterative(BstNode<int> node, int value1, int value2)
        {
            while (node != null)
            {
                if (node.Data > value1 && node.Data > value2)
                {
                    node = node.Left;
                }
                else if (node.Data < value1 && node.Data < value2)
                {
                    node = node.Right;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        private BstNode<int> LowestCommonAncestorRecursive(BstNode<int> node, int value1, int value2)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data > value1 && node.Data > value2)
            {
                return LowestCommonAncestorRecursive(node.Left, value1, value2);
            }

            if (node.Data < value1 && node.Data < value2)
            {
                return LowestCommonAncestorRecursive(node.Right, value1, value2);
            }

            return node;
        }
    }
}
