using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class SortedArrayToBst
    {
        public static void Main()
        {
            SortedArrayToBstProcessor processor = new SortedArrayToBstProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class SortedArrayToBstProcessor
    {
        int[] sortedItems;
        public void Process()
        {
            Initialize();
            ConstructBst();
        }

        private void Initialize()
        {
            sortedItems = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
        }

        private void ConstructBst()
        {
            BstNode<int> root = BuildBst(this.sortedItems, 0, this.sortedItems.Length - 1);

            Console.WriteLine("Built Binary Search Tree");
            InorderTraversal(root);
        }

        private BstNode<int> BuildBst(int[] sortedArrary, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (end + start) / 2;

            BstNode<int> bstNode = new BstNode<int> { Data = sortedArrary[mid] };
            bstNode.Left = BuildBst(sortedArrary, start, mid - 1);
            bstNode.Right = BuildBst(sortedArrary, mid + 1, end);

            return bstNode;
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
