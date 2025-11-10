using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("                            STATISTICS                              ");
        Console.WriteLine("--------------------------------------------------------------------");

        double[] Array = { 1, 5, 4.25};
        double Min = 0;
        double Max = 0;
        double Sum = 0;
        double Average = 0;
        String Calc = "";
        int lastindex = Array.Length - 1;
        String arr = ""; 
        

        for(int i = 0 ;i < Array.Length; i++)
        {
            Sum += Array[i];

            if (Calc != "")
            {
                Calc += " + ";
            }
            Calc += Array[i];

            if (i == lastindex)
            {
                arr += Array[i];
            }
            else
            {
                arr += Array[i] + " , ";
            }
            
        }
        Min = Array.Min();
        Max = Array.Max();
        Average = Sum / Array.Length;


        Console.WriteLine($"\nArray = {arr}");
        Console.WriteLine($"\nCalc Sum = {Calc}");
        Console.WriteLine($"Sum = {Sum}");
        Console.WriteLine($"\nMin = {Min}");
        Console.WriteLine($"Max = {Max}");
        Console.WriteLine($"\nCalc Average = {Sum} / {Array.Length}");
        Console.WriteLine($"Average = {Math.Round(Average,2)}");

        Console.WriteLine("\n--------------------------------------------------------------------");
    }
}