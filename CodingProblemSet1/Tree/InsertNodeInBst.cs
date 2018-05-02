using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class InsertNodeInBst
    {
        public static void Main()
        {
            InsertNodeInBstProcessor processor = new InsertNodeInBstProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class InsertNodeInBstProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            this.root = Insert(this.root, 20);
            this.root = Insert(this.root, 10);
            this.root = Insert(this.root, 15);
            this.root = Insert(this.root, 25);
            this.root = Insert(this.root, 5);
            this.root = Insert(this.root, 30);
            this.root = Insert(this.root, 35);
        }

        private BstNode<int> Insert(BstNode<int> node, int data)
        {
            if (node == null)
            {
                node = new BstNode<int> { Data = data };
                return node;
            }
            else if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }
            else
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }
    }
}
