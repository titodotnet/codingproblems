using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class DeleteNodeFromBst
    {
        public static void Main()
        {
            DeleteNodeFromBstProcessor processor = new DeleteNodeFromBstProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class DeleteNodeFromBstProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            Console.WriteLine("Inorder print of original tree");
            InorderTraversal(this.root);

            var rootNode = this.root;
            var rootAfterDelete = Delete(rootNode, 25);
            Console.WriteLine("Inorder print of tree after deletion");
            InorderTraversal(rootAfterDelete);
        }

        private BstNode<int> Delete(BstNode<int> node, int data)
        {
            if (node == null)
            {
                return node;
            }
            else if (node.Data > data)
            {
                node.Left = Delete(node.Left, data);
                //return node;
            }
            else if (node.Data < data)
            {
                node.Right = Delete(node.Right, data);
                //return node;
            }
            else
            {
                // (node.Data == data)
                // case 1: No child
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                    //return node;
                }
                // Case 2: Single child
                else if(node.Left == null)
                {
                    node = node.Right;
                    //return node;
                }
                else if (node.Right == null)
                {
                    node = node.Left;
                    //return node;
                }
                // Case 3: Two children
                else
                {
                    var minRightNode = FindMin(node.Right); // Find the minimum value from right. Max value from left also will work.
                    node.Data = minRightNode.Data; // Copy the value so that the hierarchy is maintained.
                    node = Delete(node.Right, node.Data); // Delete the duplicate node - this will end up in Case 1 or Case 2.
                    //return node;
                }
            }

            return node;
        }

        private BstNode<int> FindMin(BstNode<int> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
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

        private void InorderTraversal(BstNode<int> node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.WriteLine($"{node.Data}");
                InorderTraversal(node.Right);
            }
        }
    }
}
