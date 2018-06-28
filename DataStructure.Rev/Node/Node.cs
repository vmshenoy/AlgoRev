using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Rev.Node
{
    public sealed class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node()
        {
            Next = null;
        }

        public Node(T data)
        {
            this.Value = data;
            Next = null;
        }
    }
}
