using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Rev.Node
{
    public sealed class Node2<T>
    {
        public T Value;
        public Node2<T> Next;
        public Node2<T> Previous;

        public Node2()
        {
            Next = null;
            Previous = null;
        }

        public Node2(T data)
        {
            this.Value = data;
            Next = null;
            Previous = null;
        }
    }
}
