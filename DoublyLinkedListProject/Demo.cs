using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, data, x;
            DoublyLinkedList list = new DoublyLinkedList();
            list.CreateList();
            while (true)
            {
                Console.WriteLine("1.Display list ");
                Console.WriteLine("2. Insert i empty List ");
                Console.WriteLine("3. Insert  a Node in begining of the list ");
                Console.WriteLine("4. Insert a node at the end of the list ");
                Console.WriteLine("5. Insert a node after a specified node ");
                Console.WriteLine("6. Insert a node before specified node ");
                Console.WriteLine("7. Delete first node ");
                Console.WriteLine("8. Delete last node ");
                Console.WriteLine("9. Delete any node ");
                Console.WriteLine("10. Reverse the list ");
                Console.WriteLine("11. Quit ");
                Console.WriteLine("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 11)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("enter an element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertEmptyList(data);
                        break;
                    case 3:
                        Console.WriteLine("enter an element to be i9nserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeginning(data);
                        break;
                    case 4:
                        Console.WriteLine("enter an element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.WriteLine("enter an elemet to be inserted ");
                        data = Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("enter the element after which to be inserted ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterNode(data, x);
                        break;
                    case 6:
                        Console.WriteLine("enter an elemet to be inserted ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the element before which to be inserted ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 7:
                        list.DeleteFirstNode();
                        break;
                    case 8:
                        list.DeleteLastNode();
                        break;
                    case 9:
                        Console.WriteLine(" Enter the element to be Deleted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 10:
                        list.ReverseList();
                        break;
                    default:
                        Console.WriteLine(" Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("exiting");
        }
    }
}
