using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Rev.Node
{
    /// <summary>
    /// Class represents a binary tree node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class BNode<T>
    {
        public T Value;
        public BNode<T> Left;
        public BNode<T> Right;

        public BNode()
        {
            Left = null;
            Right = null;
        }

        public BNode(T data)
        {
            this.Value = data;
            Left = null;
            Right = null;
        }
    }
}
