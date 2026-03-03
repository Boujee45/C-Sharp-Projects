using System;

public class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
        next = null;
    }
}


public class SinglyLinkedList
{
    Node head;

    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if(head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;

        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void Delete(int value)
    {
        if (head == null) return;

        if(head.data == value)
        {
            head = head.next;
            return;
        }

        Node temp = head;

        while(temp.next != null && temp.next.data != value)
        {
            temp = temp.next;
        }

        if(temp.next != null)
        {
            temp.next = temp.next.next;
        }
        
    }

    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while(current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    public void Display()
    {
        Node temp = head;

        Console.WriteLine("Singly Linked List: ");
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }

        Console.WriteLine("NULL");
        

    }


}

public class Program
{
    public static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();

        list.Insert(5);
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        list.Delete(5);
        list.Reverse();

        list.Display();
    }
}