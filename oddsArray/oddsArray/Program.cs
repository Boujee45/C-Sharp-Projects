using System;

public class Program
{
    public static void Main(String[] Args)
    {
        try
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("                          ODDS ARRAY                      ");
            Console.WriteLine("----------------------------------------------------------");

            int[] Array = { 6, 7, 5, 1, 8, 4 };
            String odds = "";
            int lastIndex = Array.Length - 1;
            String Arrays = "";

            for (int i = 0; i < Array.Length; i++)
            {
                if (i % 2 != 0 && Array[i] % 2 != 0)
                {
                    if (odds != "")
                    {
                        odds += " , ";
                    }
                    odds += Array[i];

                }

            }
            for (int i = 0; i < Array.Length; i++)
            {
                if (Arrays != "")
                {
                    Arrays += " , ";
                }
                Arrays += Array[i];

            }

            Console.WriteLine($"\nArray = {Arrays}");
            Console.WriteLine($"Odds Array = {odds}");
            Console.WriteLine($"\t\t\tAns = {odds}");
        }
        catch(NullReferenceException err)
            {
            Console.WriteLine($"Error: {err.Message}");
        }
        finally
        {
            Console.WriteLine("\n----------------------------------------------------------");

        }
    }
}