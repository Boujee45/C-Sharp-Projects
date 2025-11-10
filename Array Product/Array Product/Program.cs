using System;
using System.Net.Http.Headers;
using System.Numerics;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("                        ARRAY PRODUCT                         ");
        Console.WriteLine("--------------------------------------------------------------");

        int[] Array = { 9, 5, 7 };
        int product = 1;
        String multiply = "";
        int lastIndex = Array.Length - 1;
        String arr = "";
        


        for (int i = 0; i < Array.Length; i++)
        {
            product *= Array[i];

            

            //Console.Write(Array[i]);

            if (i == lastIndex)
            {
                multiply += Array[i];
                arr += Array[i];
            }
            else
            {
                multiply += Array[i] + " x ";
                arr += Array[i] + " , ";
            }
            
        }
        Console.WriteLine($"Array = {arr}");
        Console.WriteLine($"Array Product = {multiply}");
        Console.WriteLine($"\t\t\tAns = { product}");

        Console.WriteLine("\n--------------------------------------------------------------");


    }
}