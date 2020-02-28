using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTreeHeight;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TreeHeight()
        {
            /*
            *               1
            *           2       3
            *       4
            *   5
            *
            */


            var rootNode = new Node(1);
            rootNode.LeftNode = new Node(2);
            rootNode.RightNode = new Node(3);

            rootNode.LeftNode.LeftNode = new Node(4);
            rootNode.LeftNode.LeftNode.LeftNode = new Node(5);

            var tree = new Tree(rootNode);
            var height = tree.CalculateTreeHeight();

            Assert.AreEqual(3, height);
        }

        [TestMethod]
        public void TreeWithZeroHeight()
        {
            /*
            *               1            
            *
            */

            var rootNode = new Node(1);

            var tree = new Tree(rootNode);
            var height = tree.CalculateTreeHeight();

            Assert.AreEqual(0, height);
        }

        [TestMethod]
        public void TreeHeightOfOne()
        {
            /*
            *               1      
            *           2       3      
            *
            */

            var rootNode = new Node(1);
            rootNode.LeftNode = new Node(2);
            rootNode.RightNode = new Node(3);

            var tree = new Tree(rootNode);
            var height = tree.CalculateTreeHeight();

            Assert.AreEqual(1, height);
        }
    }
}
