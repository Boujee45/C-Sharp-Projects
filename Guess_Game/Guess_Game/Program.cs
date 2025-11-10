using System;

public class Program
{
    public static void Main(String[] args)
    {
        try {
            String Secret_Word = "BOUJEE";

            String Guess = "";
            int Number_Of_Guesses = 0;
            int Guess_Limit = 3;
            bool Out_Of_Guesses = false;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                        GUESSING GAME                           ");
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("YOU HAVE 3 GUESSES ONLY!");
            Console.WriteLine("CLUE : A NAME");


            while (Guess.ToUpper() != Secret_Word && !Out_Of_Guesses)
            {
                if (Number_Of_Guesses < Guess_Limit)
                {
                    Console.Write("\nEnter a guess: ");
                    Guess = Console.ReadLine();

                    Number_Of_Guesses++;
                }
                else
                {
                    Out_Of_Guesses = true;
                }

            }
            if (Out_Of_Guesses)
            {
                Console.WriteLine("\nYOU LOOSE!");
            }
            else
            {
                Console.WriteLine("\n\tYOU WIN!");
            }



        }
        catch (FormatException e)
        {
            Console.WriteLine($"\n\tERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("----------------------------------------------------------------");

        }
    }
}