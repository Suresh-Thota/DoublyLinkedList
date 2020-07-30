using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListProject
{
    class DoublyLinkedList
    {
        private Node start;
        public DoublyLinkedList()
        {
            start = null;
        }
        public void InsertBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        public void InsertEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            Node p = start;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
            temp.prev = p;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter the size of the doubly linked list");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }
            Console.WriteLine("enter the first element");
            data = Convert.ToInt32(Console.ReadLine());
            InsertEmptyList(data);
            for( i = 2; i <= n; i++)
            {
                Console.WriteLine("Enter the next element");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void InsertAfterNode(int data,int x)
        {
            Node p = start;
            Node temp = new Node(data);
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if(p == null)
            {
                Console.WriteLine(x + " is not present in the list");
            }
            else
            {
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                {
                    p.next.prev = temp;
                }
                p.next = temp;
            }
        }
        public void InsertBefore(int data, int x)
        {
            Node temp = new Node(data);
            Node p = start;
            if(start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if(start.info == x)
            {
                temp.next = start;
                start.prev = temp;
                start = temp;
                return;
            }
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if(p == null)
            {
                Console.WriteLine(x +" is not present in the list");
            }
            else
            {
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }
        public void DeleteFirstNode()
        {
            if (start == null)//list is empty
                return;
            if(start.next == null)
            {
                start = null;
                return;
            }
            start = start.next;
            start.prev = null;
        }
        public void DeleteLastNode()
        {
            if (start == null)//list is empty
                return;
            if (start.next == null)
            {
                start = null;
                return;
            }
            Node p = start;
            while (p.next != null)
            {
                p = p.next;
            }
            p.prev.next = null;
        }
        public void DeleteNode(int x)
        {
            if(start == null)
            {
                return;
            }
            if(start.next == null)
            {
                if (start.info == x)
                    start = null;
                else
                    Console.WriteLine(x + " not found");
                return;
            }
            if (start.info == x)
            {
                start = start.next;
                start.prev = null;
                return;
            }
            Node p = start.next;
            while (p.next != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p.next != null)
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
            else
            {
                if (p.info == x)
                {
                    p.prev.next = null;
                }
                else
                    Console.WriteLine(x + " not found"); 
            }
        }
        public void ReverseList()
        {
            if (start == null)
                return;
            Node p1 = start;
            Node p2 = p1.next;
            p1.next = null;
            p1.prev = p2;
            while (p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            start = p1;

        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Console.WriteLine("List is :  ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + "  ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
