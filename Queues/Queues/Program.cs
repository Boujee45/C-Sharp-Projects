using System;

public class Program
{
    public static void Main(String[] args)
    {
        Queue<String> queue = new Queue<String>();

        queue.Enqueue("Oscar");
        queue.Enqueue("Jane");
        queue.Enqueue("John");
        queue.Enqueue("James");
        queue.Enqueue("Reginah");

        queue.Dequeue();

        Console.WriteLine(queue.Peek());

        Console.WriteLine(queue.Count);

        foreach (String i in queue)
        {
            Console.WriteLine(i);
        }
    }
}