using System;

public class Program
{
    public static void Main(string[] args)
    {
        Stack<String> stack = new Stack<String>();

        stack.Push("Oscar");
        stack.Push("Jane");
        stack.Push("Mary");
        stack.Push("Magdalene");
        stack.Push("Reginah");

        stack.Pop();

        Console.WriteLine(stack.Peek());

        /*for(int i = 0; i < 1000000000; i++)
        {
            stack.Push("Him");
        }*/

        foreach(String i in stack)
        {
            Console.WriteLine(i);
        }
    }
}