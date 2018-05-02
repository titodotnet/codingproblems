using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class BstHeight
    {
        public static void Main()
        {
            BstHeightProcessor processor = new BstHeightProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class BstHeightProcessor
    {
        BstNode<int> root;
        public void Process()
        {
            Initialize();
            CalculateHeight(this.root);
        }

        private void Initialize()
        {
            this.root = new BstNode<int> { Data = 20 };
            this.root.Left = new BstNode<int> { Data = 10 };
            this.root.Right = new BstNode<int> { Data = 30 };

            //this.root.Left.Left = new Node<int> { Data = 5 };
            this.root.Left.Right = new BstNode<int> { Data = 15 };

            this.root.Right.Left = new BstNode<int> { Data = 25 };
            //this.root.Right.Right = new Node<int> { Data = 35 };

            this.root.Right.Left.Right = new BstNode<int> { Data = 27 };
            this.root.Right.Left.Right.Right = new BstNode<int> { Data = 28 };
        }

        private void CalculateHeight(BstNode<int> node)
        {
            Console.WriteLine($"Node height is: {CalculateNodeHeight(node)}");
        }

        private int CalculateNodeHeight(BstNode<int> node)
        {
            if (node == null)
            {
                return -1;
            }

            var leftHeight = CalculateNodeHeight(node.Left) + 1;
            var rightHeight = CalculateNodeHeight(node.Right) + 1;

            return Math.Max(leftHeight, rightHeight);
            //return (leftHeight > rightHeight) ? leftHeight : rightHeight;
        }

        private int CalculateNodeHeight1(BstNode<int> node)
        {
            if (node == null)
            {
                return -1;
            }

            var leftHeight = CalculateNodeHeight(node.Left);
            var rightHeight = CalculateNodeHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
