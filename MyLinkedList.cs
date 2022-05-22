using System;
using System.Collections;
using System.Collections.Generic;

public class MyLinkedList
{
    public MyLinkedList next { get; set; }
    private MyLinkedList head;
    private MyLinkedList tail;
    private List<MyLinkedList> list;
    private int val;


    public MyLinkedList()
    {
        list = new List<MyLinkedList>();
    }

    public void PrintList()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
            Console.Write(list[i].val + " ");
        }
    }

    public int Get(int index)
    {
        if (list.Count > index)
        {
            return list[index].val;
        }
        return -1;
    }

    public void AddAtHead(int val)
    {
        if (head == null)
        {
            head = new MyLinkedList();
            head.val = val;
            list.Add(head);
        }
        else
        {
            MyLinkedList n = new MyLinkedList();
            n.val = val;
            MyLinkedList o = head;
            head = n;
            head.next = o; 
            list.Insert(0, head);
            n = null;
        }
    }

    public void AddAtTail(int val)
    {
        if (tail == null)
        {
            tail = new MyLinkedList();
            tail.val = val;
            list.Add(tail);
        }
        else
        {
            MyLinkedList n = new MyLinkedList();
            n.val = val;
            MyLinkedList o = tail;
            tail = n;
            o.next = tail;
            list.Add(tail);
            n = null;
        }
    }

    public void AddAtIndex(int index, int val)
    {
        MyLinkedList n = new MyLinkedList();
        n.val = val;
        if (index <= 0)
        {
            AddAtHead(val);
            return;
        }
        if (list.Count > index)
        {
            list[index - 1].next = n;
            n.next = list[index];
            list.Insert(index, n);
        }
        else if (list.Count == index)
        {
            AddAtTail(val);
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (list.Count <= 0 || head == null) return;
        if (index <= 0)
        {
            head = head.next;
            return;
        }
        else
        {
            if (list.Count > index)
            {
                list[index - 1].next = list[index + 1];
                list[index].next = null;
            }
            else if (list.Count == index)
            {
                list[index - 1].next = null;
            }
        }
        list.RemoveAt(index);
    }
}