using System;
using System.Linq.Expressions;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            String Users_Choice = "";
            String Computers_Choice = "";
            String Answers = "";
            bool PlayAgain = true;

            while (PlayAgain)
            {
                Users_Choice = "";
                Computers_Choice = "";
                Answers = "";

                while (Users_Choice != "ROCK" && Users_Choice != "PAPER" && Users_Choice != "SCISSORS")
                {

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("             ROCK,PAPER AND SCISSORS GAME              ");
                    Console.WriteLine("-------------------------------------------------------");

                    Console.WriteLine("Choices include: ");
                    Console.WriteLine("\t         1.ROCK");
                    Console.WriteLine("\t         2.PAPER");
                    Console.WriteLine("\t         3.SCISSORS");



                    Console.Write("\nEnter ROCK,PAPER or SCISSORS: ");
                    Users_Choice = Console.ReadLine();
                    Users_Choice = Users_Choice.ToUpper();

                    Random random = new Random();
                    switch (random.Next(1, 4))
                    {
                        case 1:
                            Computers_Choice = "ROCK";
                            break;
                        case 2:
                            Computers_Choice = "PAPER";
                            break;
                        case 3:
                            Computers_Choice = "SCISSORS";
                            break;

                    }
                    Console.WriteLine($"\nUsers_Choice: {Users_Choice}");
                    Console.WriteLine($"Computers_Choice: {Computers_Choice}");


                    switch (Users_Choice)
                    {
                        case "ROCK":
                            if (Computers_Choice == "ROCK")
                            {
                                Console.WriteLine("\n\t\tIt's a draw.");
                            }
                            else if (Computers_Choice == "PAPER")
                            {
                                Console.WriteLine("\n\t\tYou Loose!");
                            }
                            else
                            {
                                Console.WriteLine("\n\t\tYou Win!");
                            }
                            break;
                        case "PAPER":
                            if (Computers_Choice == "ROCK")
                            {
                                Console.WriteLine("\n\t\tYou WIn!");
                            }
                            else if (Computers_Choice == "PAPER")
                            {
                                Console.WriteLine("\n\t\tIts a draw!");
                            }
                            else
                            {
                                Console.WriteLine("\n\t\tYou Loose!");
                            }
                            break;
                        case "SCISSORS":
                            if (Computers_Choice == "ROCK")
                            {
                                Console.WriteLine("\n\t\tYou Loose!");
                            }
                            else if (Computers_Choice == "PAPER")
                            {
                                Console.WriteLine("\n\t\tYou Win!");
                            }
                            else
                            {
                                Console.WriteLine("\n\t\tIts a draw!");
                            }
                            break;
                        default:
                            Console.WriteLine("\nINVALID INPUT");
                            break;

                    }
                    
                        Console.Write("\nWould you like to Play Again (Y/N): ");
                        Answers = Console.ReadLine();
                        Answers = Answers.ToUpper();

                        if (Answers == "Y")
                        {
                            PlayAgain = true;
                        }
                        else if (Answers == "N")
                        {
                            PlayAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("PLEASE INPUT Y or N!");
                        }
                   
                }
                
                Console.WriteLine("\nThanks for playing");
            }
            //sConsole.ReadKey();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("\n\t\t\tBYE!");
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}