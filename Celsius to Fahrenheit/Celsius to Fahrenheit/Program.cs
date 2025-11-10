using System;
using System.Linq.Expressions;

public class program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                TEMPERATURE CONVERTER                 ");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("\nEnter a number in Celsius : ");
            double Celsius = Convert.ToDouble(Console.ReadLine());

            String Formula = "(" + Celsius + " * 9 / 5) + 32";
            double Fahrenheit = (Celsius * 9 / 5) + 32;

            Console.WriteLine($"\nInput = {Celsius}");
            Console.WriteLine($"\nConversion = {Formula}");
            Console.WriteLine($"\n\t\tAns = {Fahrenheit} fa ");

           }
        catch (Exception ex)
        {
            Console.WriteLine($"\n\tERROR : {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("------------------------------------------------------");

        }
    }
}