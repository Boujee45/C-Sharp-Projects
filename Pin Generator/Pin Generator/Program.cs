using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("==================================================================");
        Console.WriteLine("                          PIN GENERATOR                           ");
        Console.WriteLine("==================================================================");

        for (int i = 0; i < 5;i++)
        {
            Console.WriteLine($"{i + 1}. {generatePin(4)}");
        }

        Console.WriteLine("==================================================================");
    }


    public static String generatePin(int length)
    {
        String numbers = "0123456789";

        Random random = new Random();
        StringBuilder pin = new StringBuilder();

        for(int i = 0; i < length;i++)
        {
            int index = random.Next(numbers.Length);
            pin.Append(numbers[index]);

        }
        return pin.ToString();
    }
}