using System;

namespace SinglyLinkedList
{
//1. Create a LinkedList when it doesn't already exist (DONE)

//2. Insert a new Node into the Linked List

//3. Search through a LinkedList to find an element

//**4. Delete a single element from a Linked List
    //not simple to do here, because I'll break the chain. Will do in Doubly Linked List

//5. Delete an entire Linked List

//--------------------------------------------------------------------------------------------

//1.

    class LinkedList
    {
        Node head;
    
        private class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

        }

        void deleteList()
        {
            head = null;
        }

        void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + " ");
                n = n.next;
            }

            if(head == null)
            {
                Console.WriteLine("List deleted.");
            }
        }

        
        static void Main(string[] args)
        {
            LinkedList singleLL = new LinkedList();

            singleLL.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);

            singleLL.head.next = second;

            second.next = third;
            third.next = fourth;

            singleLL.printList();
            singleLL.deleteList();
            singleLL.printList();
        }
    }
}
