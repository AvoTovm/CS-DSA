using System;

namespace BinarySearchTree
{
    internal class main
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(2);

            tree.LevelOrderTraverse();

            tree.RemoveNode(5);
            Console.WriteLine("after removing 5 ");
            tree.LevelOrderTraverse();

            Console.WriteLine("Searching");
            tree.Search(2);

            Console.WriteLine("Inorder ");
            tree.InorderTraversal();

        }
    }
}
