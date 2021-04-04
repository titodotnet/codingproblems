using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Tree
{
    class BstPrintAllCousins
    {
        public static void Main()
        {
            BstPrintAllCousinsProcessor processor = new BstPrintAllCousinsProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class BstPrintAllCousinsProcessor
    {
        BstNode<int> root;

        public void Process()
        {
            this.Initialize();
            this.PrepareAndPrintCousins();
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
        }

        private void PrepareAndPrintCousins()
        {
            // Select the node for which cousins have to printed.
            BstNode<int> node = this.root.Left.Left;
            int nodeLevel = this.CalculateLevel(this.root, node, 1);
            PrintAllCousins(this.root, node, 1, nodeLevel);
        }

        private int CalculateLevel(BstNode<int> currentRoot, BstNode<int> node, int currentLevel)
        {
            if (currentRoot == null)
            {
                return 0;
            }

            if (currentRoot == node)
            {
                return currentLevel;
            }

            int leftTraveralLevel = CalculateLevel(currentRoot.Left, node, currentLevel + 1);

            if (leftTraveralLevel > 0)
            {
                return leftTraveralLevel;
            }

            return CalculateLevel(root.Right, node, currentLevel + 1);
        }

        private void PrintAllCousins(BstNode<int> currentRoot, BstNode<int> node, int currentRootLevel, int nodeLevel)
        {
            if (currentRoot == null)
            {
                return;
            }

            if (currentRootLevel == nodeLevel - 1)
            {
                if (!((currentRoot.Left != null && currentRoot.Left == node) || (currentRoot.Right != null && currentRoot.Right == node)))
                {
                    Console.Write($"{currentRoot.Left.Data} ");
                    Console.Write($"{currentRoot.Right.Data} ");
                }
            }

            PrintAllCousins(currentRoot.Left, node, currentRootLevel + 1, nodeLevel);
            PrintAllCousins(currentRoot.Right, node, currentRootLevel + 1, nodeLevel);
        }
    }
}
