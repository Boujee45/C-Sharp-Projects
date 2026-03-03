using System;

public class Program
{
    public static void Main(String[] args)
    {
        LinkedList<String> linkedList = new LinkedList<String>();

        linkedList.AddFirst("Oscar");
        linkedList.AddFirst("Jane");
        linkedList.AddFirst("cynthia");//stacks
        linkedList.AddFirst("faith");
        linkedList.AddFirst("George");

        //linkedList.AddLast("Him"); //queue

        linkedList.Reverse();

        linkedList.RemoveFirst();

        foreach (String i in linkedList)
        {
            Console.WriteLine(i);
        }
    }
}