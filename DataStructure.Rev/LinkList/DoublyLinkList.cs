using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.Rev.Node;

namespace DataStructure.Rev.LinkList
{
    public class DoublyLinkList
    {
        Node2<int> head = null;
        Node2<int> tail = null;

        /// <summary>
        /// function to add the value to the D-LL at the end
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            Node2<int> node = new Node2<int>(value);

            //case-1:list is empty, then initilize the head and tail
            if (head == null)
            {
                head = node;
                tail = node;
            }
            //case-2:list has atleast 1 ele, then append to the end
            else
            {
                node.Previous = tail; //init the back ref
                tail.Next = node;
                tail = node;
            }
        }

        /// <summary>
        /// function to search a value in the D-LL
        /// </summary>
        /// <param name="value">value to search</param>
        /// <returns>result</returns>
        public bool Search(int value)
        {
            Node2<int> temp = head;

            ////traverse throught the list till the item is found or end is reached
            while (temp != null && temp.Value != value)
                temp = temp.Next;

            //check if the entire list is traversed
            if (temp == null)
                return false;

            return true;
        }

        /// <summary>
        /// function to delete a node fromt the D-LL
        /// </summary>
        /// <param name="value">node with value to delete</param>
        /// <returns>result</returns>
        public bool Delete(int value)
        {
            //case-1:list is empty, item cannot be deleted
            if (head == null)
                return false;

            Node2<int> temp = head;

            //value at the first location
            if (head.Value == value)
            {
                //case-2:node to remove is the only node in the list
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                //case-3:node to remove is the head node
                else
                {
                    head = head.Next;
                    head.Previous = null;
                }
                return true;
            }

            //Treaser the LL till we find the node
            while (temp.Next != null && temp.Next.Value != value)
                temp = temp.Next;

            if (temp.Next != null)
            {
                //case-4:node to remove is the tail node
                if (temp.Next == tail)
                {
                    tail = tail.Previous;                    
                    tail.Next = null;
                }
                //case-5:node to remove is between head and tail
                else
                {
                    temp.Next = temp.Next.Next;
                    temp.Next.Previous = temp;
                }
                return true;
            }

            //case-6:node to remove dosen't exist
            return false;
        }

        /// <summary>
        /// function to travers the entire D-LL
        /// </summary>
        public void Travese()
        {
            Node2<int> temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }

        /// <summary>
        /// function to travers the entire D-LL in reverse O(n)
        /// </summary>
        public void ReverseTravese()
        {
            Node2<int> temp = tail;

            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Previous;
            }
        }
    }
}
