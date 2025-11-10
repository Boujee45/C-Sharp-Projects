using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {
        Dictionary<String,Double> grocery = new Dictionary<string, double>()
        {
            {"apples",1.90},
            {"oranges",2.20},
            {"bananas",1.80},
            {"carrots",1.20},
            {"sweet-corn",1.70}
        };
        Console.WriteLine("********************************************");
        Console.WriteLine("                 GROCERIES                  ");
        Console.WriteLine("********************************************");
        foreach (var shopping in grocery)
        {
            Console.WriteLine($"{shopping.Key}: ${shopping.Value:F2}");
        }
        Console.WriteLine("********************************************");


        Console.Write("Enter number of grocery items: ");
        int n = int.Parse(Console.ReadLine());

        double total = 0.0;

        List<(String item, Double quantity)> orderList = new List<(String, Double)>();

        Console.WriteLine("Enter the grocery item and the quantity respectively(e.g. apples 2): ");

        
        for (int i = 0; i < n; i++)
        {
            String[] input = Console.ReadLine().Trim().Split(' ');
            String item = input[0].ToLower();
            Double quantity = Double.Parse(input[1], CultureInfo.InvariantCulture);
            orderList.Add((item, quantity));


            
        }

        

        Console.WriteLine("\n\nItem\t\tQty(kg)\tPrice/kg\tSubtotal");

        Console.WriteLine("------------------------------------------------------------");


        foreach (var order in orderList)
        {
            if (grocery.ContainsKey(order.item))
            {
                double price = grocery[order.item];
                double subtotal = price * order.quantity;

                total += subtotal;

                Console.WriteLine($"{order.item}\t\t{order.quantity:F2}\t${price:F2}\t\t{subtotal:F2}");
            }
            else
            {
                Console.WriteLine($"Item '{order.item}' not found in the price list.");
            }

        }

        Console.WriteLine("------------------------------------------------------------");

        Console.WriteLine($"Total Cost:\t\t\t\t${total:F2}");
            
        }
    }
