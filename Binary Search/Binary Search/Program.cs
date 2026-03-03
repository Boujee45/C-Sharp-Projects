using System;

public class Program
{
    public static void Main(String[] args)
    {
        int[] array = { 20, 11, 4, 5, 2, 9, 8, 7, 1, 0, 19, 14, 15, 3 };
        int target = 7;

        //bubbleSort(array);
        //insertionSort(array);
        selectionSort(array);

        Console.Write("Sorted Array = ");
        foreach(int i in array)
        {
            Console.Write(i + " ");
        }

        int index = binarySearch(array, target);

        if(index != - 1)
        {
            Console.WriteLine($"\nBinary Search = {target} found at index {index}");
        }
        else
        {
            Console.WriteLine($"\nBinary Search = {target} not found!");
        }

    }

    private static void selectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }

    private static void insertionSort(int[] array)
    {
        for(int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while(j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

    }

    private static int binarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while(low <= high)
        {
            int middle = low + (high - low) / 2;
            int value = array[middle];

            if (value < target)
            {
                low = middle + 1;
            }
            else if(value > target)
            {
                high = middle - 1;
            }
            else
            {
                return middle;
            }
        }

        return -1;
    }

    private static void bubbleSort(int[] array)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}