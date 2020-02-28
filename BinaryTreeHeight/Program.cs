using System;

namespace BinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new Node(1);
            rootNode.LeftNode = new Node(2);
            rootNode.RightNode = new Node(3);

            rootNode.LeftNode.LeftNode = new Node(4);
            rootNode.LeftNode.LeftNode.LeftNode = new Node(5);

            var tree = new Tree(rootNode);
            Console.WriteLine($"Tree height is {tree.CalculateTreeHeight()}");
        }
    }
}
