class CNode
{
    public int data;
    public CNode next;

    public CNode(int value)
    {
        data = value;
    }
}

class CircularLinkedList
{
    CNode head;

    public void Insert(int value)
    {
        CNode newNode = new CNode(value);

        if (head == null)
        {
            head = newNode;
            head.next = head;
            return;
        }

        CNode temp = head;

        while (temp.next != head)
        {
            temp = temp.next;
        }

        temp.next = newNode;
        newNode.next = head;
    }

    public void Display()
    {
        CNode temp = head;

        do
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        while (temp != head);

        Console.WriteLine("(back to head)");
    }
}

class Program
{
    static void Main()
    {
        CircularLinkedList list = new CircularLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        list.Display();
    }
}