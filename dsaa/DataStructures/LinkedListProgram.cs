using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.dsa
{
    using System;


    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }

    class LinkedList
    {
        public Node head;

        public void addfirst(int data)
        {

            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;

            }
            else
            {
                newnode.next = head;
                head = newnode;
            }
        }

        public void addlast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
        }

        public void addpos(int data, int pos)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else if (head == null || pos == 0)
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                Node temp = head;
                for (int i = 0; i < pos - 1; i++)
                {
                    if (temp.next == null)
                    {
                        Console.WriteLine("out of bounds");
                        return;
                    }
                    temp = temp.next;
                }
                newnode.next = temp.next;
                temp.next = newnode;
            }
        }



        public void deletefirst()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                head = head.next;
            }
        }
        public void deletelast()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            } else if (head.next==null)
            {
                head = null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;

                }
                temp.next = null;
            }
        }

        public void deletepos(int pos)
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else if (head == null || pos == 0)
            {
                head = head.next;
            }
            else
            {
                Node temp = head;
                Node prev = head.next;
                for (int i = 0; i < pos - 1; i++)
                {
                    if (temp.next == null)
                    {
                        Console.WriteLine("out of bounds");
                        return;
                    }
                    temp = temp.next;
                    prev = prev.next;
                }
                temp.next = prev.next;
                prev.next = null;

            }
        }


        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + "==>");
                    temp = temp.next;
                }
                Console.Write("null");
            }

        }
    }


    public class LinkedListProgram
    {


        public static void Main(string[] args)
        {

            LinkedList ll = new LinkedList();
            ll.addfirst(10);
            ll.addlast(20);
            ll.addlast(30);

            ll.addpos(25, 2);
            ll.deletepos(2);

            ll.display();

        }

    }
}
