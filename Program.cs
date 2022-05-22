using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myList = new MyLinkedList();
            myList.AddAtHead(1);
            myList.AddAtTail(3);
            myList.AddAtIndex(1, 2);
            myList.Get(0);
            myList.DeleteAtIndex(0);
            myList.Get(0);
            myList.PrintList();
        }
    }
}
