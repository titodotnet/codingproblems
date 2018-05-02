using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class BSTMinMaxValue
    {
        public static void Main()
        {
            BSTMinMaxValueProcessor processor = new BSTMinMaxValueProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BSTMinMaxValueProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            Initialize();
            FindMinMax(this.root);
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
        }

        private void FindMinMax(BstNode<int> node)
        {
            var min = FindMinRecursive(node);
            var max = FindMaxRecursive(node);

            Console.WriteLine($"Min value: {min.Data}");
            Console.WriteLine($"Max value: {max.Data}");

            FindMinIterative(node);
            FindMaxIterative(node);
        }

        private BstNode<int> FindMinRecursive(BstNode<int> node)
        {
            if (node == null)
            {
                return null;
            }

            //var result = FindMin((node.Left != null) ? node.Left : node.Right);
            var result = FindMinRecursive(node.Left);
            return result ?? node;
        }

        private BstNode<int> FindMaxRecursive(BstNode<int> node)
        {
            if (node == null)
            {
                return null;
            }

            var result = FindMaxRecursive(node.Right);
            return result ?? node;
        }


        private void FindMinIterative(BstNode<int> node)
        {
            if (node == null)
            {
                Console.WriteLine("Invalid tree");
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            Console.WriteLine($"Min values is {node.Data}");
        }

        private void FindMaxIterative(BstNode<int> node)
        {
            if (node == null)
            {
                Console.WriteLine("Invalid tree");
            }


            while (node.Right != null)
            {
                node = node.Right;
            }

            Console.WriteLine($"Max values is {node.Data}");
        }
    }

    class BstNode<T>
    {
        public T Data { get; set; }

        public BstNode<T> Left { get; set; }

        public BstNode<T> Right { get; set; }
    }
}
