// PRACTICAL 2 (ALGORITHMS AND DATA STRUCURES)

using System;

namespace DataStructuresPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Search & Sorting Techniques\n");

            // 1. Accept 10 integers from user
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Invalid input! Enter a valid integer: ");
                }
            }

            // Display original array
            Console.WriteLine("\nOriginal array:");
            PrintArray(arr);

            // ------------------- SEARCH SECTION -------------------
            Console.Write("\nEnter key to search: ");
            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                Console.WriteLine("Invalid key. Using 0 as default.");
                key = 0;
            }

            // Linear Search
            int linearIndex = LinearSearch(arr, key);
            Console.WriteLine($"\nLinear Search: Key {key} found at index {(linearIndex >= 0 ? linearIndex.ToString() : "-1 (not found)")}");

            // Binary Search (needs sorted array → we sort later, so doing it after sorting)

            // ------------------- SORTING SECTION -------------------
            Console.WriteLine("\nSorting results:");

            // Bubble Sort
            int[] bubbleArr = (int[])arr.Clone();
            BubbleSort(bubbleArr);
            Console.Write("Bubble Sort   → ");
            PrintArray(bubbleArr);

            // Insertion Sort
            int[] insertArr = (int[])arr.Clone();
            InsertionSort(insertArr);
            Console.Write("Insertion Sort → ");
            PrintArray(insertArr);

            // Selection Sort
            int[] selectArr = (int[])arr.Clone();
            SelectionSort(selectArr);
            Console.Write("Selection Sort → ");
            PrintArray(selectArr);

            // Now that we have a sorted array, do Binary Search on one of them
            Console.WriteLine("\nBinary Search (on sorted array - using Selection Sort result):");
            int binaryIndex = BinarySearch(selectArr, key);
            Console.WriteLine($"Binary Search: Key {key} found at index {(binaryIndex >= 0 ? binaryIndex.ToString() : "-1 (not found)")}");

            Console.WriteLine("\nProgram completed. Press any key to exit...");
            Console.ReadKey();
        }

        // ------------------- SEARCH FUNCTIONS -------------------

        static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return mid;

                if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        // ------------------- SORTING FUNCTIONS -------------------

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                }

                // swap
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }

        // ------------------- HELPER -------------------

        static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
