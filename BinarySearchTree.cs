using System;
using System.Diagnostics;

namespace ExampleCodePlayground
{


/*
    class Tree
    {
        public TreeNode root;
        public class TreeNode
        {
            public String name;
            public TreeNode[] children;
        }

        void InOrderTraversal(TreeNode node) //In-Order Traversal means to "visit" (often: print) the left branch, then the current node, and finally: the right branch
        {
            if(node != null)
            {
                InOrderTraversal(node.left);
                visit(node);
                InOrderTraversal(node.right);
            
                //When performed on a binary search tree, it visits the nodes in ascending order (hence the name "in-order")
            }

        }

        void preOrderTraversal(TreeNode node) //Pre-Order Traversal visits the current node before its child nodes (hence the name "pre-order")
        {
            if(node != null)
            {
                visit(node);
                preOrderTraversal(node.left);
                preOrderTraversal(node.right);

                //in a pre-order traversal, the root is always the first node visited
            }
        }

        void postOrderTraversal(TreeNode node) //Post-order traversal visits the current node after its child nodes (hence the name "post-order")
        {
            if(node != null)
            {
                postOrderTraversal(node.left);
                postOrderTraversal(node.right);
                visit(node);

                //in a post-order traversal, the root node is always the last node visited
            }
        }
    }
    */

    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;
    }

    class Tree
    {
        public Node insert(Node root, int v)
        {
            if(root == null)
            {
                //create a root node if it does not exist
                root = new Node();
                root.value = v;
            }

            else if (v < root.value)
            {
                root.leftChild = insert(root.leftChild, v); //root exists: append the value of v to the left child of the current node
            }

            else
            {
                root.rightChild = insert(root.rightChild, v); //root and left child exist: insert value into the right child of the current node
            }

            return root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            traverse(root.leftChild);
            traverse(root.rightChild);
        }
    }

    class BinarySearchTree
    {
        static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree();
            int SIZE = 2000;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating new array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = new Stopwatch();
            watch.Start(); //StartNew() isn't showing up for some reason

            for(int i = 0; i < SIZE; i++)
            {
                root = bst.insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
  
