using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class NodeTree
    {
        public int Data { get; set; }
        public NodeTree Left { get; set; }
        public NodeTree Right { get; set; }

        public NodeTree(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public NodeTree Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private NodeTree InsertRec(NodeTree root, int data)
        {
            if (root == null)
            {
                root = new NodeTree(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }

        public void InOrderTraversal(NodeTree root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }
    }
}
