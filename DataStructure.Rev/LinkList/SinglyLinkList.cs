using DataStructure.Rev.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Rev.LinkList
{
    public class SinglyLinkList
    {
        Node<int> head = null;
        Node<int> tail = null;

        /// <summary>
        /// function to add the value to the LL at the end
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            Node<int> node = new Node<int>(value);

            //case-1:empty list
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else//case-2:the list has atlest one ele, append the new node to tail and update tail pointer
            {
                tail.Next = node;
                tail = node;
            }
        }

        /// <summary>
        /// function to search a value in the LL
        /// </summary>
        /// <param name="value">value to search</param>
        /// <returns>result</returns>
        public bool Search(int value)
        {
            Node<int> temp = head;

            //traverse throught the list till the item is found or end is reached
            while (temp != null && temp.Value != value)
                temp = temp.Next;

            //check if the entire LL is traversed
            if (temp == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// function to delete a node fromt the LL
        /// </summary>
        /// <param name="value">node with value to delete</param>
        /// <returns>result</returns>
        public bool Delete(int value)
        {
            //case-1:list is empty
            if (head == null)
            {
                return false;
            }

            Node<int> temp = head;

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
                    tail = temp;
                    tail.Next = null;
                }
                //case-5:node to remove is between head and tail
                else
                {
                    temp.Next = temp.Next.Next;
                }
                return true;
            }

            //case-6:node to remove dosen't exist
            return false;
        }

        /// <summary>
        /// function to travers the entire LL
        /// </summary>
        public void Travese()
        {
            Node<int> temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }

        /// <summary>
        /// function to travers the entire LL in reverse in O(n^2)
        /// </summary>
        public void ReverseTravese()
        {
            Node<int> print = tail;
            Node<int> prev = head;

            while (print != head)
            {
                prev = head;
                while (prev != null && prev.Next != print)
                    prev = prev.Next;

                Console.WriteLine(print.Value);
                print = prev;                
            }
            //Print the head node
            Console.WriteLine(print.Value);
        }
    }
}
