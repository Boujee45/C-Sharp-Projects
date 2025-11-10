using System;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                      FACTORIAL CALCULATOR                     ");
            Console.WriteLine("---------------------------------------------------------------");

            int factorial = 1;
            string explanation = "";

            Console.Write("\nEnter a number for the factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"\nInput  =  {num}");

                Console.WriteLine($"\n\tError : There is no factorial for a negative number!");
            }
            else if (num == 0)
            {
                Console.WriteLine($"\nInput  =  {num}");
                Console.WriteLine($"Factorial = {explanation}");
                Console.WriteLine($"\n\t\tAns  =  {factorial}");

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                    explanation += i;

                    if (i < num)
                        explanation += " x ";
                }

                Console.WriteLine($"\nInput  =  {num}");
                Console.WriteLine($"Factorial = {explanation}");
                Console.WriteLine($"\n\t\tAns  =  {factorial}");

            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\n\tERROR : {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("---------------------------------------------------------------");

        }
    }
}