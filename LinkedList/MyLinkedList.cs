using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }
        public MyLinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }
        public MyLinkedList(T val)
        {
            Node<T> head = new Node<T>(val);
            this.Head = head;
            this.Count = 1;
        }
        public MyLinkedList(List<T> list)
        {
            //Create a Linked list using a list
            this.Count = list.Count;
            this.Head = new Node<T>(list[0]);
            Node<T> curr = this.Head;
            int i = 1;
            while (i < list.Count)
            {
                curr.Next = new Node<T>(list[i]);
                curr = curr.Next;
                i++;
            }
        }
        public void AddFront(T val)
        {
            //O(1) time complexity
            Node<T> node = new Node<T>(val);
            if (this.Head == null) this.Head = node;
            else
            {
                Node<T> first = this.Head;
                node.Next = first;
                this.Head = node;
            }
            this.Count++;
        }
        public void Append(T val)
        {
            //Add an element at the end of the linked list
            Node<T> node = new Node<T>(val);
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                Node<T> i = this.Head;
                //O(N) time complexity since while loop will traverse N times
                while (i.Next != null)
                {
                    i = i.Next;
                }
                i.Next = node;
            }
        }
        public void AddNext(T value, T existingValue)
        {
            Node<T> node = new Node<T>(value);
            Node<T> curr = this.Head;
            while (!curr.Data.Equals(existingValue))
            {
                curr = curr.Next;
            }
            node.Next = curr.Next;
            curr.Next = node;
            this.Count++;
        }
        public Node<T> Find(T value)
        {
            Node<T> curr = this.Head;
            while (!(curr is null) && !curr.Data.Equals(value))
            {
                curr = curr.Next;
            }
            if (curr == null) return null;
            return curr;
        }
        public void RemoveFront()
        {
            if (this.Head is null || this.Count == 0) return;
            this.Head = this.Head.Next;
            this.Count--;
        }
        public void Remove(T value)
        {
            if (this.Head == null) return;
            if (this.Head.Data.Equals(value)) this.RemoveFront();
            Node<T> prev = this.Head;
            Node<T> curr = prev.Next;
            while (curr != null && !curr.Data.Equals(value))
            {
                prev = curr;
                curr = prev.Next;
            }
            prev.Next = curr.Next;
            curr.Next = null;
            this.Count--;
        }

        public void Print()
        {
            //Print all the values of the linked list
            Node<T> curr = this.Head;
            while (curr != null)
            {
                Console.Write(curr.Data + " ");
                curr = curr.Next;
            }
            Console.WriteLine();
        }
        public class Node<K>
        {
            public K Data { get; set; }
            public Node<K> Next { get; set; }
            public Node(K data)
            {
                this.Data = data;
            }
        }
    }
}
