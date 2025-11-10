using System;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                       MULTIPLICATION TABLE                     ");
            Console.WriteLine("----------------------------------------------------------------");

            Console.Write("\nEnter a number for the multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"\n{i}. {num} x {i} = {num * i}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\nERROR  :  {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\t\tTHANK YOU , BYE!");
            Console.WriteLine("----------------------------------------------------------------");

        }
    }
}