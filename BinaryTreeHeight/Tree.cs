using System;

namespace BinaryTreeHeight
{
    public class Tree
    {
        public Node Root { get; private set; }
        
        public Tree(Node root)
        {
            this.Root = root;
        }

        private int RecursiveHeight(Node root)
        {
            return root == null ? -1 : 1 + Math.Max(RecursiveHeight(root.LeftNode), RecursiveHeight(root.RightNode));
        }

        public int CalculateTreeHeight() => RecursiveHeight(this.Root);

    }
}