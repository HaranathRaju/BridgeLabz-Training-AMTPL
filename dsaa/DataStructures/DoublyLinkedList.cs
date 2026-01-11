using System;

class DNode
{
    public int value;
    public DNode next;
    public DNode prev;

    public DNode(int value)
    {
        this.value = value;
    }
}

class DoublyList
{
    public DNode head;

    public void InsertFront(int value)
    {
        DNode node = new DNode(value);

        if (head == null)
        {
            head = node;
        }
        else
        {
            node.next = head;
            head.prev = node;
            head = node;
        }
    }

    public void InsertEnd(int value)
    {
        DNode node = new DNode(value);

        if (head == null)
        {
            head = node;
            return;
        }

        DNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = node;
        node.prev = temp;
    }

    public void InsertAt(int value, int position)
    {
        DNode node = new DNode(value);

        if (position == 0 || head == null)
        {
            InsertFront(value);
            return;
        }

        DNode temp = head;
        for (int i = 0; i < position - 1; i++)
        {
            if (temp.next == null)
            {
                Console.WriteLine("Position out of range!");
                return;
            }
            temp = temp.next;
        }

        node.next = temp.next;
        node.prev = temp;

        if (temp.next != null)
            temp.next.prev = node;

        temp.next = node;
    }


    public void DeleteFront()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.next == null)
        {
            head = null;
            return;
        }

        head = head.next;
        head.prev = null;
    }
    public void DeleteEnd()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.next == null)
        {
            head = null;
            return;
        }

        DNode temp = head;

        while (temp.next != null)
            temp = temp.next;

        temp.prev.next = null;
    }

    public void DeleteAt(int position)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (position == 0)
        {
            DeleteFront();
            return;
        }

        DNode temp = head;
        for (int i = 0; i < position; i++)
        {
            if (temp == null)
            {
                Console.WriteLine("Position out of range!");
                return;
            }
            temp = temp.next;
        }

        if (temp.next != null)
            temp.next.prev = temp.prev;

        if (temp.prev != null)
            temp.prev.next = temp.next;
    }

  
    public void Reverse()
    {
        if (head == null)
            return;

        DNode current = head;
        DNode temp = null;

        while (current != null)
        {
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;
            current = current.prev;
        }

        if (temp != null)
            head = temp.prev;
    }


    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        DNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.value + " <--> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}

public class DoublyLinkedList
{
    public static void Main()
    {
        DoublyList dl = new DoublyList();

        dl.InsertFront(10);
        dl.InsertEnd(20);
        dl.InsertEnd(30);
        dl.InsertAt(25, 2);

        dl.Display();

        dl.DeleteAt(2);
        dl.Display();

        dl.Reverse();
        dl.Display();
    }
}