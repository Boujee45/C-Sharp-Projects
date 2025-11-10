using System;
using System.Linq.Expressions;

public class program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                   SQUARE CALCULATOR                   ");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("\nEnter side of a square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double Perimeter = side * 4;

            double Area = side * side;

            Console.WriteLine($"\n\tInput = {side}cm");
            Console.WriteLine($"\tPerimeter = {Perimeter} cm ");
            Console.WriteLine($"\tArea = {Area} cm^2 ");

            //Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR : {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}