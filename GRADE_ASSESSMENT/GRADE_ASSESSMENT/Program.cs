using System;

public class Program
{
    public static void Main(String[] args)
    {
        try {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                      GRADE ASSESSMENT APP                          ");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Enter the number of points attained by the Student: ");
            int points = Convert.ToInt32(Console.ReadLine());

            if (points >= 90 && points <= 100)
            {

                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = A");
                Console.WriteLine("\n\tEXCELLENT!");
            }
            else if (points >= 80 && points < 90)
            {
                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = B");
                Console.WriteLine("\n\tKEEP IT UP!");

            }
            else if (points >= 70 && points < 80)
            {
                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = C");
                Console.WriteLine("\n\tYOU CAN DO BETTER!");

            }
            else if (points >= 60 && points < 70)
            {
                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = D");
                Console.WriteLine("\n\tPULL UP YOUR SOCKS!");
            }
            else if (points >= 50 && points < 60)
            {
                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = E");
                Console.WriteLine("\n\tFAIL!");

            }
            else if (points >= 0 && points < 50)
            {
                Console.WriteLine($"\nINPUT = {points}");
                Console.WriteLine($"GRADE = F");
                Console.WriteLine("\n\tPOOR!");

            }
            else
            {
                Console.WriteLine("\n\tERROR : POINTS CANNOT EXCEED 100!");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine($"\n\tERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("--------------------------------------------------------------------");

        }
    }
}