using System;

public class Program()
{
    public static void Main(String[] args)
    {
        Console.WriteLine("=====================================================================");
        Console.WriteLine("                            PALINDROME APP                           ");
        Console.WriteLine("=====================================================================");

        bool is_Alive = true;

        while (is_Alive)
        {
            String original, reverse = "";

            Console.Write("\n> Enter a String palindrome(q to quit): ");
            original = Console.ReadLine().ToLower();

            int length = original.Length;

            
            for (int i = length - 1; i >= 0; i--)
            {
                reverse = reverse + original.ElementAt(i);
            }
            if (original.Equals(reverse) && original != "q")
            {
                Console.WriteLine("\n\t~YES!");
                Console.WriteLine($"\t~{original} is a Palindrome.");
            }
            else if(original != reverse && original != "q")
            {
                Console.WriteLine("\n\t~NO!");
                Console.WriteLine($"\t~{original} is not a Palindrome.");
            }
            else
            {
                break;
            }
            /*
            Console.Write("Enter a palindrome: ");
            String name = Console.ReadLine().ToLower();

            char[] charArray = name.ToArray();

            Array.Reverse(charArray);

            String reversed = new String(charArray);

            if(name == reversed)
            {
                Console.WriteLine("This is a Palindrome");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome");
            }*/
            //Console.ReadKey();
            

        }
        Console.WriteLine("\n=====================================================================");
    }

}