using System;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("                         NUMBER GUESSING APP                      ");
            Console.WriteLine("------------------------------------------------------------------");

            int guess = 0;
            int count = 0;

            Random random = new Random();

            int specialNumber = random.Next(0, 100);

            while (guess != specialNumber)
            {
                Console.Write("\nGuess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                count++;

                if (guess < specialNumber)
                {
                    Console.WriteLine($"\nGuess = {guess}");
                    Console.WriteLine("\t\t~Too low, try again:");
                }
                else if (guess > specialNumber)
                {
                    Console.WriteLine($"\nGuess = {guess}");
                    Console.WriteLine("\t\t~Too high, try again:");
                }
                else
                {
                    Console.WriteLine($"\nGuess = {guess}");
                    Console.WriteLine($"Tries = {count}");
                    Console.WriteLine($"\t\t~You guessed it! the number is {guess}.");
                    Console.WriteLine($"\t\t~It took you {count} tries.");
                }

            }
        }
        catch (FormatException err)
        {
            Console.WriteLine($"\t~Error : {err.Message}");
        }
        finally
        {
            Console.WriteLine("\n------------------------------------------------------------------");

        }
    }
}