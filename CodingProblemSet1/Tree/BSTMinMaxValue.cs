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
        Node<int> root;

        public void Process()
        {
            Initialize();
            FindMinMax(this.root);
        }

        private void Initialize()
        {
            this.root = new Node<int> { Data = 20 };
            this.root.Left = new Node<int> { Data = 10 };
            this.root.Right = new Node<int> { Data = 30 };

            //this.root.Left.Left = new Node<int> { Data = 5 };
            this.root.Left.Right = new Node<int> { Data = 15 };

            this.root.Right.Left = new Node<int> { Data = 25 };
            //this.root.Right.Right = new Node<int> { Data = 35 };
        }

        private void FindMinMax(Node<int> node)
        {
            var min = FindMinRecursive(node);
            var max = FindMaxRecursive(node);

            Console.WriteLine($"Min value: {min.Data}");
            Console.WriteLine($"Max value: {max.Data}");

            FindMinIterative(node);
            FindMaxIterative(node);
        }

        private Node<int> FindMinRecursive(Node<int> node)
        {
            if (node == null)
            {
                return null;
            }

            //var result = FindMin((node.Left != null) ? node.Left : node.Right);
            var result = FindMinRecursive(node.Left);
            return result ?? node;
        }

        private Node<int> FindMaxRecursive(Node<int> node)
        {
            if (node == null)
            {
                return null;
            }

            var result = FindMaxRecursive(node.Right);
            return result ?? node;
        }


        private void FindMinIterative(Node<int> node)
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

        private void FindMaxIterative(Node<int> node)
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

    class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }
}
