using System;
using System.Text;

public class Program
{
    public static void Main(String[] args)
    {
        for(int i = 0; i < 5;  i++)
        {
            Console.WriteLine(generatePin(4));
        }

    }

    public static StringBuilder generatePin(int Length)
    {
        String numbers = "0123456789";
        
        Random random = new Random();
        StringBuilder pin = new StringBuilder();

        for(int i = 0; i < Length; i++)
        {
            int index = random.Next(numbers.Length);
            
            pin.Append(numbers[index]);
        }

        return pin;
    }
}