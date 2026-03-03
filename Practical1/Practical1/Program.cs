
// PRACTICAL 1 (ALGORITHMS AND DATA STRUCTURES)

using System;

namespace DataStructuresMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== DATA STRUCTURES MENU ===");
                Console.WriteLine("1. Arrays ");//(Student Scores)
                Console.WriteLine("2. Linked List");
                Console.WriteLine("3. Stack ");//(Array-based, size 5)
                Console.WriteLine("4. Queue ");//(Array-based, size 5)
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter choice (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice! Press any key...");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 5) break;

                switch (choice)
                {
                    case 1: ArraysOperations(); break;
                    case 2: LinkedListOperations(); break;
                    case 3: StackOperations(); break;
                    case 4: QueueOperations(); break;
                }

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }

        // ───────────────────────────────────────────────
        // 1. Arrays - Student Scores (fixed size 10)
        // ───────────────────────────────────────────────
        static void ArraysOperations()
        {
            int[] scores = new int[10];
            int count = 0; // how many valid scores we have

            Console.WriteLine("\n=== Arrays: Student Scores (max 10) ===\n");

            // Accept 10 scores
            Console.WriteLine("Enter up to 10 student scores:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Score {i + 1} (or press Enter to stop): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;

                if (int.TryParse(input, out int val))
                {
                    scores[count++] = val;
                }
                else
                {
                    Console.WriteLine("\nInvalid number - skipped.\n");
                    i--;
                }
            }

            while (true)
            {
                Console.WriteLine("\nArray current state: ");
                PrintArray(scores, count);

                Console.WriteLine("\nOptions:");
                Console.WriteLine(" a. Insert new score at index");
                Console.WriteLine(" b. Delete score at index");
                Console.WriteLine(" c. Search score (linear)");
                Console.WriteLine(" d. Update score at index");
                Console.WriteLine(" e. Back to main menu");
                Console.Write("Choose: ");

                string opt = Console.ReadLine()?.ToLower();

                if (opt == "e") break;

                if (opt == "a")
                {
                    Console.Write("Enter new score: ");
                    if (!int.TryParse(Console.ReadLine(), out int newScore)) { Console.WriteLine("Invalid."); continue; }

                    Console.Write("Enter index (0 to " + count + "): ");
                    if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 0 || idx > count || count == 10)
                    {
                        Console.WriteLine("Invalid index or array full.");
                        continue;
                    }

                    // Shift right
                    for (int i = count; i > idx; i--)
                        scores[i] = scores[i - 1];
                    scores[idx] = newScore;
                    count++;
                }
                else if (opt == "b")
                {
                    Console.Write("Enter index to delete (0 to " + (count - 1) + "): ");
                    if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 0 || idx >= count)
                    {
                        Console.WriteLine("Invalid index.");
                        continue;
                    }

                    // Shift left
                    for (int i = idx; i < count - 1; i++)
                        scores[i] = scores[i + 1];
                    count--;
                }
                else if (opt == "c")
                {
                    Console.Write("Enter score to search: ");
                    if (!int.TryParse(Console.ReadLine(), out int key)) { Console.WriteLine("Invalid."); continue; }

                    int pos = -1;
                    for (int i = 0; i < count; i++)
                    {
                        if (scores[i] == key) { pos = i; break; }
                    }
                    Console.WriteLine(pos >= 0 ? $"Found at index {pos}" : "Not found");
                }
                else if (opt == "d")
                {
                    Console.Write("Enter index to update: ");
                    if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 0 || idx >= count)
                    {
                        Console.WriteLine("Invalid index.");
                        continue;
                    }
                    Console.Write("New value: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        scores[idx] = val;
                    }
                }
            }
        }

        static void PrintArray(int[] arr, int size)
        {
            Console.Write("[ ");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + (i < size - 1 ? ", " : ""));
            Console.WriteLine(" ]");
        }

        // ───────────────────────────────────────────────
        // 2. Singly Linked List
        // ───────────────────────────────────────────────
        class Node
        {
            public int Data;
            public Node Next;
            public Node(int data) { Data = data; Next = null; }
        }

        static void LinkedListOperations()
        {
            Node head = null;
            Console.WriteLine("\n=== Singly Linked List ===\n");

            while (true)
            {
                Console.WriteLine("Current list: ");
                DisplayList(head);

                Console.WriteLine("\nOptions:");
                Console.WriteLine(" a. Insert at end");
                Console.WriteLine(" b. Delete by value");
                Console.WriteLine(" c. Reverse list");
                Console.WriteLine(" d. Back to main menu");
                Console.Write("Choose: ");

                string opt = Console.ReadLine()?.ToLower();
                if (opt == "d") break;

                if (opt == "a")
                {
                    Console.Write("Enter value: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        head = InsertAtEnd(head, val);
                    }
                }
                else if (opt == "b")
                {
                    Console.Write("Enter value to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        head = DeleteByValue(head, val);
                    }
                }
                else if (opt == "c")
                {
                    head = ReverseList(head);
                    Console.WriteLine("List reversed.");
                }
            }
        }

        static Node InsertAtEnd(Node head, int data)
        {
            Node newNode = new Node(data);
            if (head == null) return newNode;

            Node temp = head;
            while (temp.Next != null) temp = temp.Next;
            temp.Next = newNode;
            return head;
        }

        static Node DeleteByValue(Node head, int value)
        {
            if (head == null) return null;

            if (head.Data == value) return head.Next;

            Node current = head;
            while (current.Next != null && current.Next.Data != value)
                current = current.Next;

            if (current.Next != null)
                current.Next = current.Next.Next;

            return head;
        }

        static Node ReverseList(Node head)
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        static void DisplayList(Node head)
        {
            Node temp = head;
            Console.Write("Head → ");
            while (temp != null)
            {
                Console.Write(temp.Data + " → ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        // ───────────────────────────────────────────────
        // 3. Stack (Array, size 5)
        // ───────────────────────────────────────────────
        static void StackOperations()
        {
            int[] stack = new int[5];
            int top = -1;

            Console.WriteLine("\n=== Stack (Array size 5) ===\n");

            while (true)
            {
                Console.WriteLine($"Stack: top = {top}  Content: ");
                for (int i = top; i >= 0; i--) Console.Write(stack[i] + " ");
                Console.WriteLine("");

                Console.WriteLine("a. Push");
                Console.WriteLine("b. Pop");
                Console.WriteLine("c. Peek");
                Console.WriteLine("d. Back\n");
                Console.Write("Choose: ");
                string opt = Console.ReadLine()?.ToLower();

                if (opt == "d") break;

                if (opt == "a")
                {
                    if (top == 4) { Console.WriteLine("Stack Overflow!"); continue; }
                    Console.Write("Value: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        stack[++top] = val;
                        Console.WriteLine("Pushed.");
                    }
                }
                else if (opt == "b")
                {
                    if (top == -1) { Console.WriteLine("Stack Underflow!"); continue; }
                    Console.WriteLine($"Popped: {stack[top--]}");
                }
                else if (opt == "c")
                {
                    if (top == -1) Console.WriteLine("Stack empty.");
                    else Console.WriteLine($"Top: {stack[top]}");
                }
            }
        }

        // ───────────────────────────────────────────────
        // 4. Queue (Array, size 5)
        // ───────────────────────────────────────────────
        static void QueueOperations()
        {
            int[] queue = new int[5];
            int front = -1, rear = -1;

            Console.WriteLine("\n=== Queue (Array size 5) ===\n");

            while (true)
            {
                Console.Write("Queue: ");
                if (front == -1) Console.Write("empty");
                else
                {
                    for (int i = front; i <= rear; i++)
                        Console.Write(queue[i] + " ");
                }
                Console.WriteLine("");

                Console.WriteLine("\na. Enqueue");
                Console.WriteLine("b. Dequeue");
                Console.WriteLine("c. Front");
                Console.WriteLine("d. Back\n");
                Console.Write("Choose: ");
                string opt = Console.ReadLine()?.ToLower();

                if (opt == "d") break;

                if (opt == "a")
                {
                    if (rear == 4) { Console.WriteLine("Queue Overflow!"); continue; }
                    Console.Write("Value: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        if (front == -1) front = 0;
                        queue[++rear] = val;
                        Console.WriteLine("\nEnqueued.");
                    }
                }
                else if (opt == "b")
                {
                    if (front == -1 || front > rear) { Console.WriteLine("\nQueue Underflow!"); continue; }
                    Console.WriteLine($"\nDequeued: {queue[front++]}");
                    if (front > rear) { front = rear = -1; }
                }
                else if (opt == "c")
                {
                    if (front == -1) Console.WriteLine("\nQueue empty.");
                    else Console.WriteLine($"\nFront: {queue[front]}");
                }
            }
        }
    }
}
