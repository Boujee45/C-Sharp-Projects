using System;

public class Program
{
    public static void Main(String[] args)
    {
        try {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                           TAXI FARE                           ");
            Console.WriteLine("---------------------------------------------------------------");

            //Asking for user input:

            Console.Write("Enter the seconds passed during the ride: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the distance travelled: ");
            double mileage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter night or day: ");
            String type = Console.ReadLine().ToUpper();

            //Taxi_Fare(DayTime) = 2 + 0.02 x seconds + 1.2 x mileage;
            //Taxi_Fare(NightTime) = (2 + 0.02 x seconds + 1.2 x mileage) x 2;

            if (type == "DAY")
            {
                double Taxi_Fare = 2 + 0.02 * seconds + 1.2 * mileage;
                Console.WriteLine($"\nSECONDS : {seconds} s");
                Console.WriteLine($"MILEAGE : {mileage} mi");
                Console.WriteLine($"TYPE    : {type}");

                Console.WriteLine($"\n\tTAXI_FARE = ${Math.Round(Taxi_Fare, 2)}");

            }
            else if (type == "NIGHT")
            {
                //price *= 2;

                double Taxi_Fare = (2 + 0.02 * seconds + 1.2 * mileage) * 2;

                Console.WriteLine($"\nSECONDS : {seconds} s");
                Console.WriteLine($"MILEAGE : {mileage} mi");
                Console.WriteLine($"TYPE    : {type}");

                Console.WriteLine($"\n\tTAXI_FARE = ${Math.Round(Taxi_Fare, 2)}");


            }
            else
            {
                Console.WriteLine("\n\tINVALID INPUT! ; ENTER DAY OR NIGHT ONLY!");
            }

            //try ... catch block

        }
        catch (FormatException ex)
        {
            Console.WriteLine("\n\tERROR : " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\n\t\tTHANK YOU , BYE!");
            Console.WriteLine("---------------------------------------------------------------");

            
        }
    }
}