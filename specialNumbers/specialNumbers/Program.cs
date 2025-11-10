using System;
using System.Net;

public class Program
{
    public static void Main(String[] args)
    {
        String special = "";
        //String result = "";

        try
        {

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("                             SPECIAL NUMBERS                           ");
            Console.WriteLine("-----------------------------------------------------------------------");


            Console.Write("\nEnter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nInput 1 = {num1}");
            Console.WriteLine($"Input 2 = {num2}");
           // Console.WriteLine("\nSpecial Numbers = ");

            //Special numbers are numbers divisible to input without a remainder.
            //range = 1-50;
            for (int i = 1; i < 51; i++)
            {
                if (i % num1 == 0)
                {
                    special += i + ",";


                    //Console.WriteLine("\t\t\t" + i);
                }
                else if (i % num2 == 0)
                {
                    special += i + "," ;
                    //Console.WriteLine("\t\t\t" + i);
                }
            }
            Console.WriteLine($"\nSpecial Numbers = {special}");
        }
        catch(FormatException e)
        {
            Console.WriteLine($"\tERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\n-----------------------------------------------------------------------");

        }
    }
}