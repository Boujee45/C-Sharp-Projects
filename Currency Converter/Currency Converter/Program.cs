using System;

public class program
{
    
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                    CURRENCY CONVERTER                        ");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Currency Supported: ");
            Console.WriteLine("\t1.USD");
            Console.WriteLine("\t2.EUR");
            Console.WriteLine("\t3.GBP");

            Console.Write("Enter the amount you want to be converted: ");
            double Amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter the currency of the amount you entered above: ");
            string InputCurrency = Console.ReadLine().ToUpper();

            Console.Write("\nEnter the currency you want to convert into: ");
            string OutputCurrency = Console.ReadLine().ToUpper();

            
            if (InputCurrency == "USD" && OutputCurrency == "EUR")
            {
                double Euro = Amount * 0.84;
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");
                Console.WriteLine($"\n\t\tAns = {Euro} {OutputCurrency} ");

            }
            else if (InputCurrency == "USD" && OutputCurrency == "GBP")
            {
                double GBP = Amount * 0.72;
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");

                Console.WriteLine($"\n\t\tAns = {GBP} {OutputCurrency}");
            }

            else if (InputCurrency == "EUR" && OutputCurrency == "USD")
            {
                double USD = Amount * 1.18; 
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");

                Console.WriteLine($"\n\t\tAns = {USD} {OutputCurrency}");
            }
            else if (InputCurrency == "EUR" && OutputCurrency == "GBP")
            {
                double GBP = Amount * 0.86;
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");

                Console.WriteLine($"\n\t\tAns = {GBP} {OutputCurrency}");
            }
            else if (InputCurrency == "GBP" && OutputCurrency == "USD")
            {
                double USD = Amount * 1.38;
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");

                Console.WriteLine($"\n\t\tAns = {USD} {OutputCurrency}");
            }
            else if (InputCurrency == "GBP" && OutputCurrency == "EUR")
            {
                double EUR = Amount * 1.16;
                Console.WriteLine($"\nInput = {Amount} {InputCurrency}");

                Console.WriteLine($"\n\t\tAns = {EUR} {OutputCurrency}");
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT!");
            }

            }
       catch (Exception e)
        {
            Console.WriteLine($"\n\tERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\tBYE! THANKS FOR TRYING THIS APP");
            Console.WriteLine("--------------------------------------------------------------");

        }
    }
}