// PRACTICAL 3 (ALGORITHMS AND DATA STRUCTURES)

using System;
using System.Collections.Generic;

namespace PracticalExamThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Graph
            Graph graph = new Graph();

            // For BST
            BST bst = new BST();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== PRACTICAL THREE ===");
                Console.WriteLine("1. Graph Operations (Adjacency List)");
                Console.WriteLine("2. Tree Operations (Binary Search Tree)");
                Console.WriteLine("3. Recursion Operations");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter choice (1-4): ");

                string choice = Console.ReadLine()?.Trim();

                if (choice == "4") break;

                switch (choice)
                {
                    case "1":
                        GraphMenu(graph);
                        break;
                    case "2":
                        BSTMenu(bst);
                        break;
                    case "3":
                        RecursionMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // ───────────────────────────────────────────────
        // 1. Graph Operations
        // ───────────────────────────────────────────────
        static void GraphMenu(Graph graph)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Graph Operations ===");
                Console.WriteLine("Current Graph:");
                graph.DisplayGraph();

                Console.WriteLine("\na. Add Node");
                Console.WriteLine("b. Add Edge (undirected)");
                Console.WriteLine("c. Remove Node");
                Console.WriteLine("d. BFS Traversal from node");
                Console.WriteLine("e. Back to main menu");
                Console.Write("Choose: ");

                string opt = Console.ReadLine()?.ToLower();

                if (opt == "e") break;

                if (opt == "a")
                {
                    Console.Write("Enter node value (integer): ");
                    if (int.TryParse(Console.ReadLine(), out int node))
                    {
                        graph.AddNode(node);
                        Console.WriteLine($"Node {node} added.");
                    }
                    else Console.WriteLine("Invalid input.");
                }
                else if (opt == "b")
                {
                    Console.Write("Enter first node: ");
                    if (!int.TryParse(Console.ReadLine(), out int u)) { Console.WriteLine("Invalid."); continue; }

                    Console.Write("Enter second node: ");
                    if (!int.TryParse(Console.ReadLine(), out int v)) { Console.WriteLine("Invalid."); continue; }

                    graph.AddEdge(u, v);
                    Console.WriteLine($"Edge {u} ↔ {v} added.");
                }
                else if (opt == "c")
                {
                    Console.Write("Enter node to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int node))
                    {
                        graph.RemoveNode(node);
                        Console.WriteLine($"Node {node} and its edges removed (if existed).");
                    }
                }
                else if (opt == "d")
                {
                    Console.Write("Enter starting node for BFS: ");
                    if (int.TryParse(Console.ReadLine(), out int start))
                    {
                        Console.WriteLine("\nBFS Traversal:");
                        graph.BFS(start);
                    }
                    else Console.WriteLine("Invalid node.");
                }
            }
        }

        // ───────────────────────────────────────────────
        // 2. BST Operations
        // ───────────────────────────────────────────────
        static void BSTMenu(BST bst)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Binary Search Tree Operations ===");
                Console.WriteLine("Current BST (Inorder):");
                bst.InorderTraversal();
                //Console.WriteLine();

                Console.WriteLine("a. Insert value");
                Console.WriteLine("b. Search value");
                Console.WriteLine("c. Inorder Traversal");
                Console.WriteLine("d. Preorder Traversal");
                Console.WriteLine("e. Postorder Traversal");
                Console.WriteLine("f. Back to main menu");
                Console.Write("\nChoose: ");

                string opt = Console.ReadLine()?.ToLower();

                if (opt == "f") break;

                if (opt == "a")
                {
                    Console.Write("Enter value to insert: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        bst.Insert(val);
                        Console.WriteLine($"{val} inserted.");
                    }
                }
                else if (opt == "b")
                {
                    Console.Write("Enter value to search: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        bool found = bst.Search(val);
                        Console.WriteLine(found ? $"\n{val} found in BST." : $"\n{val} not found.");
                    }
                    Console.ReadLine();
                }
                else if (opt == "c")
                {
                    Console.WriteLine("\nInorder: ");
                    bst.InorderTraversal();
                    Console.ReadLine();
                }
                else if (opt == "d")
                {
                    Console.WriteLine("\nPreorder: ");
                    bst.PreorderTraversal();
                    Console.ReadLine();
                }
                else if (opt == "e")
                {
                    Console.WriteLine("\nPostorder: ");
                    bst.PostorderTraversal();
                    Console.ReadLine();
                }
            }
        }

        // ───────────────────────────────────────────────
        // 3. Recursion Operations
        // ───────────────────────────────────────────────
        static void RecursionMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Recursion Operations ===");
                Console.WriteLine("a. Factorial");
                Console.WriteLine("b. Fibonacci sequence (first n terms)");
                Console.WriteLine("c. Back to main menu");
                Console.Write("\nChoose: ");

                string opt = Console.ReadLine()?.ToLower();

                if (opt == "c") break;

                if (opt == "a")
                {
                    Console.Write("\nEnter number for factorial: ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                    {
                        long result = Factorial(n);
                        Console.WriteLine($"\nFactorial({n}): ");
                        Console.WriteLine($"\t{n}! = {result}");
                        //Console.ReadLine();
                    }
                    else Console.WriteLine("Invalid (use non-negative integer).");
                    Console.ReadLine();
                }
                else if (opt == "b")
                {
                    Console.Write("\nEnter number of Fibonacci terms: ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                    {
                        Console.Write($"\nFibonacci({n}): ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(Fibonacci(i));
                            if (i < n - 1) Console.Write(", ");
                        }
                        Console.WriteLine();
                        //Console.ReadLine();
                    }
                    else Console.WriteLine("Invalid (use non-negative integer).");
                    Console.ReadLine();
                }
            }
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    // ───────────────────────────────────────────────
    // Graph Class (Adjacency List)
    // ───────────────────────────────────────────────
    class Graph
    {
        private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        public void AddNode(int node)
        {
            if (!adjList.ContainsKey(node))
                adjList[node] = new List<int>();
        }

        public void AddEdge(int u, int v)
        {
            AddNode(u);
            AddNode(v);
            if (!adjList[u].Contains(v)) adjList[u].Add(v);
            if (!adjList[v].Contains(u)) adjList[v].Add(u); // undirected
        }

        public void RemoveNode(int node)
        {
            if (adjList.ContainsKey(node))
            {
                foreach (var neighbor in adjList[node])
                {
                    adjList[neighbor].Remove(node);
                }
                adjList.Remove(node);
            }
        }

        public void DisplayGraph()
        {
            if (adjList.Count == 0)
            {
                Console.WriteLine("Graph is empty.");
                return;
            }

            foreach (var kvp in adjList)
            {
                Console.Write($"{kvp.Key} → ");
                foreach (var neighbor in kvp.Value)
                    Console.Write(neighbor + " ");
                Console.WriteLine();
            }
        }

        public void BFS(int start)
        {
            if (!adjList.ContainsKey(start))
            {
                Console.WriteLine("Start node not found.");
                Console.ReadLine();
                return;
            }


            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                foreach (int neighbor in adjList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    // ───────────────────────────────────────────────
    // Binary Search Tree
    // ───────────────────────────────────────────────
    class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    class BST
    {
        private TreeNode root;

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

        public bool Search(int value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(TreeNode node, int value)
        {
            if (node == null) return false;
            if (node.Value == value) return true;

            return value < node.Value
                ? SearchRecursive(node.Left, value)
                : SearchRecursive(node.Right, value);
        }

        public void InorderTraversal()
        {
            InorderRecursive(root);
            Console.WriteLine();
        }

        private void InorderRecursive(TreeNode node)
        {
            if (node == null) return;
            InorderRecursive(node.Left);
            Console.Write(node.Value + " ");
            InorderRecursive(node.Right);
        }

        public void PreorderTraversal()
        {
            PreorderRecursive(root);
            Console.WriteLine();
        }

        private void PreorderRecursive(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");
            PreorderRecursive(node.Left);
            PreorderRecursive(node.Right);
        }

        public void PostorderTraversal()
        {
            PostorderRecursive(root);
            Console.WriteLine();
        }

        private void PostorderRecursive(TreeNode node)
        {
            if (node == null) return;
            PostorderRecursive(node.Left);
            PostorderRecursive(node.Right);
            Console.Write(node.Value + " ");
        }
    }
}
