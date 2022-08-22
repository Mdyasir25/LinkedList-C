using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>(new List<int>() { 2, 3, 5, 6 });
            list.Print();
            list.AddFront(1);
            list.Print();
            list.AddNext(4, 3);
            list.Append(7);
            list.Print();
            list.RemoveFront();
            list.Print();
            list.Remove(4);
            list.Remove(7);
            list.Print();
            MyLinkedList<int>.Node<int> node = new LinkedList.MyLinkedList<int>.Node<int>(5);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Find(6).Data);
            Console.ReadLine();
        }
    }
}
