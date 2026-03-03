class DNode
{
    public int data;
    public DNode next;
    public DNode prev;

    public DNode(int value)
    {
        data = value;
    }
}

class DoublyLinkedList
{
    DNode head;

    public void Insert(int value)
    {
        DNode newNode = new DNode(value);

        if (head == null)
        {
            head = newNode;
            return;
        }

        DNode temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newNode;
        newNode.prev = temp;
    }

    public void Display()
    {
        DNode temp = head;

        while (temp != null)
        {
            Console.Write(temp.data + " <-> ");
            temp = temp.next;
        }

        Console.WriteLine("NULL");
    }
}

class Program
{
    static void Main()
    {
        DoublyLinkedList list = new DoublyLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);

        list.Display();
    }
}