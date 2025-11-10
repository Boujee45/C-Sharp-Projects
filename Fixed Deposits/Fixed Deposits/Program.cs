using System;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                   FIXED DEPOSITS APP                         ");
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("Enter an Investment Amount: ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the duration of fixed deposits: ");
            double n = Convert.ToDouble(Console.ReadLine());
           
            double A = P * Math.Pow((1 + r / 100), n);

            Console.WriteLine($"\nInvestment Amount = ${P}");
            Console.WriteLine($"Rate of Interest = {r} %");
            Console.WriteLine($"Duration = {n} years");
            Console.WriteLine($"Fixed Deposits = {P} x (1 + {r}/100)^{n}");

            Console.WriteLine($"\n\t\tFixed Deposits = ${Math.Round(A,2)}");

            }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("--------------------------------------------------------------");

        }
    }
}