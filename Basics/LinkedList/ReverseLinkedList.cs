using System;
using System.Collections.Generic;

class Reverselinkedlist
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);

        Console.WriteLine("Original LinkedList:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
       
        ReverseLinkedList(list);

        Console.WriteLine("Reversed LinkedList:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

    static void ReverseLinkedList<T>(LinkedList<T> linkedList)
    {
        LinkedListNode<T> current = linkedList.First;
        LinkedListNode<T> next;

        while (current != null)
        {
            next = current.Next;
            linkedList.Remove(current);
            linkedList.AddFirst(current);
            current = next;
        }
    }
}
