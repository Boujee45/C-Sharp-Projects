using System;

public class Program
{
    //main method:
    public static void Main(String[] args)
    {
        try {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                    SPEED TICKET APP                         ");
            Console.WriteLine("-------------------------------------------------------------");

            //Asking for User Inputs:

            Console.Write("Enter the Vehicle's Speed: ");
            int Speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\t1.Town");
            Console.WriteLine("\t\t2.Outside-of-Town");
            


            Console.Write("Choose or Enter the Area: ");
            String Area = Console.ReadLine().ToUpper();
            
            //If .. Else if .. Else Statement:
            //Condition must be true for output

            if (Area == "TOWN" && Speed <= 50 || Area == "1")
            {
                int Penalty = 0;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");
            }
            else if (Area == "TOWN" && Speed <= 60 || Area == "1")
            {
                int Penalty = 60;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "TOWN" && Speed <= 80 || Area == "1")
            {
                int Penalty = 150;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "TOWN" && Speed > 80 || Area == "1")
            {
                int Penalty = 300;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "OUTSIDE-OF-TOWN" && Speed <= 80 || Area == "2")
            {
                int Penalty = 0;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "OUTSIDE-OF-TOWN" && Speed <= 90 || Area == "2")
            {
                int Penalty = 45;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "OUTSIDE-OF-TOWN" && Speed <= 120 || Area == "2")
            {
                int Penalty = 100;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else if (Area == "OUTSIDE-OF-TOWN" && Speed > 120 || Area == "2")
            {
                int Penalty = 200;

                Console.WriteLine($"\nAREA : {Area}");
                Console.WriteLine($"SPEED : {Speed}km/hr ");
                Console.WriteLine($"PENALTY : ${Penalty}");


            }
            else
            {
                Console.WriteLine("\n\tINVALID INPUT!");
            }
        }

        //try ... catch ... finally block

        catch (FormatException e)
        {
            Console.WriteLine($"\n\tERROR : {e.Message}");
        }
        finally
        {
            Console.WriteLine("\n\t\t\tBYE BYE!");
            Console.WriteLine("-------------------------------------------------------------");

        }
    }
}
//End of the Code