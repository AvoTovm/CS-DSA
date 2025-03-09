using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public void LevelOrderTraverse()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode temp = q.Peek();
                q.Dequeue();

                Console.Write(temp.value + " ");
                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }

            Console.WriteLine("\n");
        }

        public void InorderTraversal()
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;

            while(curr != null || stack.Count != 0)
            {
                while(curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Peek();
                stack.Pop();

                Console.Write(curr.value + " ");

                curr = curr.right;
            }
        }

        public void Insert(int value)
        {
            TreeNode NewNode = new TreeNode(value);

            if (root == null)
            {
                root = NewNode;
                return;
            }

            TreeNode curr = root;
            TreeNode parent = null;

            while (curr != null)
            {
                parent = curr;
                if (value < curr.value)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            if (value < parent.value)
            {
                parent.left = NewNode;
            }
            else
            {
                parent.right = NewNode;
            }
        }

        public void RemoveNode(int value)
        {
            TreeNode curr = root;
            TreeNode parent = null;

            while (curr != null && curr.value != value)
            {
                parent = curr;
                if (curr.value > value)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            if(curr == null)
            {
                Console.WriteLine("Node " + value + " not found");
                return;
            }

            // case 1 has no children

            if(curr.right == null && curr.left == null)
            {
                if(curr == root) root = null;
                else if(parent.left == curr)
                {
                    parent.left = null;
                }
                else
                {
                    parent.right = null;
                }
            }

            // case 2 has one child

            else if(curr.left == null || curr.right == null)
            {
                TreeNode child = curr.left ?? curr.right;

                if(curr == root) root = null;
                else if(parent.left == curr) 
                { 
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }
            }

            // case 3 has two children

            else
            {
                TreeNode succsessorParent = curr;
                TreeNode succsessor = curr.right;

                while(succsessor.left != null)
                {
                    succsessorParent = succsessor;
                    succsessor = succsessor.right;
                }

                curr.value = succsessor.value;

                if(succsessorParent.left == succsessor)
                {
                    succsessorParent.left = succsessor.right;
                }
                else
                {
                    succsessorParent.right = succsessor.right;
                }
            }
        }

        public void Search(int value)
        {
            TreeNode curr = root;

            int steps = 0;

            while(curr != null)
            {
                if(curr.value == value)
                {
                    Console.WriteLine("The " + value + " found in " + steps + " steps");
                    return;
                }else if(curr.value > value)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
                steps++;
            }

        }
    }
}

