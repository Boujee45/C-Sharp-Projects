using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<String, Double> menu = new Dictionary<String, Double>()
        {
            {"hot-chocolate", 1.20},
            {"orange-juice", 0.80},
            {"coke", 1.10},
            {"dark-coffee", 1.60},
            {"tea", 1.45},
            {"pizza", 1.50},
            {"chips", 1.75},
            {"Hamburger", 2.45}
        }; 

        Console.WriteLine("-----------------MENU--------------------");
        foreach (var n in menu)
        {           
            Console.WriteLine($"{n.Key:.10}: ${n.Value:F2}");
        }
        Console.WriteLine("------------------------------------------");

        Double total = 0.0;       
        String input;
        List<String> cart = new List<String>();
        

        while (true)
        {
            Console.Write("Select a food item(q to quit): ");
            input = Console.ReadLine().Trim().ToLower();



            if (input == "q")
                break;

            if (menu.ContainsKey(input))
            {
                total += menu[input];

                double price = menu[input];
                cart.Add($"{input} - ${price}");
            }
            else
            {
                Console.WriteLine("\nInvalid Food item!, Try Again!\n");
            }
        }
        Console.WriteLine();
        Console.WriteLine("---------------YOUR ORDER------------------");

        foreach (String order in cart)
        {
            Console.WriteLine(order);
        }
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine($"Total is: ${total:F2}");
        Console.WriteLine($"\t\t= ${total:F2}");
        
    }
}