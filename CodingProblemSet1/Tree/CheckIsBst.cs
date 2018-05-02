using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    // Is Binary tree is a valid Binary Search Tree.
    class CheckIsBst
    {
        public static void Main()
        {
            CheckIsBstProcessor processor = new CheckIsBstProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class CheckIsBstProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            Console.WriteLine($"Is BST : {IsBst(this.root)}");
        }

        private bool IsBst(BstNode<int> node)
        {
            if (node.Left == null && node.Right == null)
            {
                return true;
            }

            var isLeftBst = true;
            var isRightBst = true;
            if (node.Left != null)
            {
                isLeftBst = (node.Data > node.Left.Data) && IsBst(node.Left);
            }

            if (node.Right != null)
            {
                isRightBst = (node.Data < node.Right.Data) && IsBst(node.Right);
            }
            
            return (isLeftBst && isRightBst);
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

    }
}
