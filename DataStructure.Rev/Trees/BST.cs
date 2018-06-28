using DataStructure.Rev.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Rev.Trees
{
    /// <summary>
    /// BST:Binary search tree, every node has at max 2 nodes
    /// left node is "<" the root node and right node is ">=" root node
    /// insertion, lookup & deletion can be done in O(logn) time, given the tree is balanced
    /// </summary>
    public class BST
    {
        BNode<int> root;

        public void Insert(int value)
        {
            BNode<int> node = new BNode<int>(value);

            //case-1:Tree is empty, given node becomes the root
            if (root == null)
                root = node;
            //case-2:iteratively call the function until BST condition is satified
            else
                Insert(root, value);
        }

        private void Insert(BNode<int> parent, int value)
        {
            if (value < parent.Value)
            {
                if (parent.Left == null)
                    parent.Left = new BNode<int>(value);
                else
                    Insert(parent.Left, value);
            }
            else
            {
                if (parent.Right == null)
                    parent.Right = new BNode<int>(value);
                else
                    Insert(parent.Right, value);
            }
        }

        public bool Search(int value)
        {
            //case-1:Empty tree
            if (root == null)
                return false;
            return Search(root, value);
        }

        private bool Search(BNode<int> parent, int value)
        {
            //case-2:Ele not found in list
            if (parent == null)
                return false;

            //case-3:Ele found in list
            if (parent.Value == value)
                return true;
            else if (value < parent.Value)
                return Search(parent.Left, value);
            else
                return Search(parent.Right, value);
        }

        public bool Delete(int value)
        {
            //case-1:Empty tree
            if (root == null)
                return false;
            return Delete(root, value);
        }

        private bool Delete(BNode<int> parent, int value)
        {
            //ToDo:Deletion Logic
            return false;
        }
    }
}
