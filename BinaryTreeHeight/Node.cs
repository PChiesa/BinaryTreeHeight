namespace BinaryTreeHeight
{
    public class Node
    {
        public Node(int data)
        {
            this.Data = data;
        }
        public int Data { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }
    }
}