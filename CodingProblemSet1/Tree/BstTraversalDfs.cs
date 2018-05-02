using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class BstTraversalDfs
    {
        public static void Main()
        {
            BstTraversalDfsProcessor processor = new BstTraversalDfsProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class BstTraversalDfsProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            DepthFirstSearch();
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

        private void DepthFirstSearch()
        {
            Console.WriteLine("Preorder traversal");
            PreorderTraversal(this.root);

            Console.WriteLine("Inorder traversal");
            InorderTraversal(this.root);

            Console.WriteLine("Postorder traversal");
            PostorderTraversal(this.root);
        }

        private void PreorderTraversal(BstNode<int> node)
        {
            if (node != null)
            {
                Console.WriteLine($"{node.Data}");
                PreorderTraversal(node.Left);
                PreorderTraversal(node.Right);
            }
        }

        private void InorderTraversal(BstNode<int> node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.WriteLine($"{node.Data}");
                InorderTraversal(node.Right);
            }
        }

        private void PostorderTraversal(BstNode<int> node)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left);
                PostorderTraversal(node.Right);
                Console.WriteLine($"{node.Data}");
            }
        }
    }
}
